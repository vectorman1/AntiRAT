using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AntiRAT
{
    class RATAlerter
    {

        private const string trojanUrl = "http://www.simovits.com/trojans/trojans.html";
        private const string portLookupUrl = "http://www.speedguide.net/port.php?port=";
        private const string ipLookupUrl = "http://ip-api.com/json/";
        private const string netstatCmd = "/C netstat -aon | find \"ESTABLISHED\"";
        private string[] badPorts;
        private bool detected;

        public TextBox TextBoxOutput { get; private set; }
        public Label SystemStatus { get; set; }
        public Label LastPortDetected { get; set; }

        public RATAlerter(TextBox tbOut)
        {
            this.TextBoxOutput = tbOut;
        }

        public void Initialize()
        {
            Console.SetOut(new ControlWriter(this.TextBoxOutput));
            Console.Write("RATAlerter v0.1 Initialized...");
            Console.Write("Standby for command...");
        }

        public void Scan()
        {
            string ports = GetPortsFromTrojanDb();
            string cleanPorts = StripLettersFromTrojanDb(ports);
            Console.WriteLine("Commencing scan on netstat for every port...");
            string netstatOutput = GetNetstatOutput();
            badPorts = CleanBadPortsArray(badPorts);
            detected = false;
            foreach (var port in badPorts)
            {
                if (netstatOutput.Contains(":" + port + " "))
                {
                    Console.WriteLine("Bad port detected!, {0}", port);
                    detected = true;
                    this.SystemStatus.Text = "At Risk";
                    this.SystemStatus.ForeColor = System.Drawing.Color.DarkRed;
                    LastPortDetected.Text = ":" + port;
                }
                
            }
            if (detected == false)
            {
                this.SystemStatus.Text = "Safe";
                this.SystemStatus.ForeColor = System.Drawing.Color.DarkGreen;
                Console.WriteLine("No bad ports detected. System is safe.");
            }
        }

        private string GetPortsFromTrojanDb()
        {
            Console.WriteLine("Fetching RAT ports from {0}...", trojanUrl);
            WebRequest req = WebRequest.Create(trojanUrl);
            WebResponse res = req.GetResponse();
            Stream data = res.GetResponseStream();
            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
            }
            Console.WriteLine("Success!");
            Console.WriteLine("Cleaning up HTML...");
            string cleanHtml = CleanUpHtml(html, "<br>");
            Console.WriteLine("Trojan ports fetched.");
            return cleanHtml;
        }

        private string GetNetstatOutput()
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = netstatCmd;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            Console.WriteLine("Executing {0}...", netstatCmd);
            proc.Start();
            Console.WriteLine("Success!");
            return proc.StandardOutput.ReadToEnd();
        }
        private string StripLettersFromTrojanDb(string html)
        {
            html = Regex.Replace(html, @"[^\d]", " ");
            html = Regex.Replace(html, @"[ ]+", " ");
            badPorts = html.Split(' ');
            Console.WriteLine("The bad ports are {0}.", badPorts.Length);

            return html;
        }
        private string[] CleanBadPortsArray(string[] ports)
        {
            string[] safePorts = { "0", "443", "80", "137", "50130" };

            foreach (var safePort in safePorts)
            {
                ports = ports.Where(o => o != safePort).ToArray();
            }
            return ports;
        }
        private string CleanUpHtml(string str, string subStr)
        {
            return Regex.Replace(str, "<.*?>", String.Empty);
        }

    }
}
