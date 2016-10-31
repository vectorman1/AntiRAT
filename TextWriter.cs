using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiRAT
{
    class ControlWriter : TextWriter
    {
        private TextBox textbox;

        public ControlWriter(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            textbox.AppendText(value);
            textbox.AppendText("\r\n");
        }

        public override void WriteLine(string value)
        {
            textbox.AppendText(value);
            textbox.AppendText("\r\n");
        }
        public override Encoding Encoding
        {
            get
            {
                return Encoding.ASCII;
            }
        }
    }
}
