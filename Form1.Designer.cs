namespace AntiRAT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.lblLastTimeScanned = new System.Windows.Forms.Label();
            this.lblLastSuspiciousPort = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(251, 319);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtbOutput
            // 
            this.txtbOutput.Location = new System.Drawing.Point(15, 208);
            this.txtbOutput.Multiline = true;
            this.txtbOutput.Name = "txtbOutput";
            this.txtbOutput.ReadOnly = true;
            this.txtbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbOutput.Size = new System.Drawing.Size(221, 134);
            this.txtbOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "System Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last time scanned:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last suspicious port:";
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSystemStatus.Location = new System.Drawing.Point(132, 13);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(53, 13);
            this.lblSystemStatus.TabIndex = 7;
            this.lblSystemStatus.Text = "Unknown";
            // 
            // lblLastTimeScanned
            // 
            this.lblLastTimeScanned.AutoSize = true;
            this.lblLastTimeScanned.Location = new System.Drawing.Point(132, 42);
            this.lblLastTimeScanned.Name = "lblLastTimeScanned";
            this.lblLastTimeScanned.Size = new System.Drawing.Size(36, 13);
            this.lblLastTimeScanned.TabIndex = 8;
            this.lblLastTimeScanned.Text = "Never";
            // 
            // lblLastSuspiciousPort
            // 
            this.lblLastSuspiciousPort.AutoSize = true;
            this.lblLastSuspiciousPort.Location = new System.Drawing.Point(132, 70);
            this.lblLastSuspiciousPort.Name = "lblLastSuspiciousPort";
            this.lblLastSuspiciousPort.Size = new System.Drawing.Size(33, 13);
            this.lblLastSuspiciousPort.TabIndex = 9;
            this.lblLastSuspiciousPort.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Output:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(12, 143);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 354);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLastSuspiciousPort);
            this.Controls.Add(this.lblLastTimeScanned);
            this.Controls.Add(this.lblSystemStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RAT Alerter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.Label lblLastTimeScanned;
        private System.Windows.Forms.Label lblLastSuspiciousPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
    }
}

