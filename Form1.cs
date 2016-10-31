using System;
using System.Windows.Forms;

namespace AntiRAT
{
    public partial class Form1 : Form
    {
        RATAlerter RatAlerter;
        public Form1()
        {
            InitializeComponent();
            RatAlerter = new RATAlerter(txtbOutput);
            RatAlerter.Initialize();
            RatAlerter.SystemStatus = lblSystemStatus;
            RatAlerter.LastPortDetected = lblLastSuspiciousPort;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = System.Drawing.Color.Crimson;
            lblStatus.Text = "Working";
            RatAlerter.Scan();
            lblLastTimeScanned.Text = DateTime.Now.ToString();
            lblStatus.Text = "Idle";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }
        private void txtbOutput_TextChanged(object sender, EventArgs e)
        {
            txtbOutput.ScrollToCaret();
        }

    }
}
