namespace FormHost
{
    partial class FormHost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTCPNET = new System.Windows.Forms.CheckBox();
            this.cbWSHTTP = new System.Windows.Forms.CheckBox();
            this.cbMEX = new System.Windows.Forms.CheckBox();
            this.cbBSHTTP = new System.Windows.Forms.CheckBox();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTCPNET);
            this.groupBox1.Controls.Add(this.cbWSHTTP);
            this.groupBox1.Controls.Add(this.cbMEX);
            this.groupBox1.Controls.Add(this.cbBSHTTP);
            this.groupBox1.Controls.Add(this.txtBaseAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Infomation";
            // 
            // cbTCPNET
            // 
            this.cbTCPNET.AutoSize = true;
            this.cbTCPNET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTCPNET.Location = new System.Drawing.Point(37, 179);
            this.cbTCPNET.Name = "cbTCPNET";
            this.cbTCPNET.Size = new System.Drawing.Size(85, 20);
            this.cbTCPNET.TabIndex = 3;
            this.cbTCPNET.Text = "TCP.NET";
            this.cbTCPNET.UseVisualStyleBackColor = true;
            // 
            // cbWSHTTP
            // 
            this.cbWSHTTP.AutoSize = true;
            this.cbWSHTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWSHTTP.Location = new System.Drawing.Point(37, 142);
            this.cbWSHTTP.Name = "cbWSHTTP";
            this.cbWSHTTP.Size = new System.Drawing.Size(86, 20);
            this.cbWSHTTP.TabIndex = 3;
            this.cbWSHTTP.Text = "WSHTTP";
            this.cbWSHTTP.UseVisualStyleBackColor = true;
            // 
            // cbMEX
            // 
            this.cbMEX.AutoSize = true;
            this.cbMEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMEX.Location = new System.Drawing.Point(37, 65);
            this.cbMEX.Name = "cbMEX";
            this.cbMEX.Size = new System.Drawing.Size(55, 20);
            this.cbMEX.TabIndex = 3;
            this.cbMEX.Text = "MEX";
            this.cbMEX.UseVisualStyleBackColor = true;
            // 
            // cbBSHTTP
            // 
            this.cbBSHTTP.AutoSize = true;
            this.cbBSHTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBSHTTP.Location = new System.Drawing.Point(37, 105);
            this.cbBSHTTP.Name = "cbBSHTTP";
            this.cbBSHTTP.Size = new System.Drawing.Size(101, 20);
            this.cbBSHTTP.TabIndex = 3;
            this.cbBSHTTP.Text = "Basic HTTP";
            this.cbBSHTTP.UseVisualStyleBackColor = true;
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(116, 23);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(200, 24);
            this.txtBaseAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Address";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(357, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START HOSTING";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Maroon;
            this.btnStop.Location = new System.Drawing.Point(520, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(156, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP HOSTING";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(358, 63);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(184, 24);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "SERVICE STATUS";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(362, 90);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(314, 156);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.Text = "";
            // 
            // FormHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 258);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM HOST SERVICE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTCPNET;
        private System.Windows.Forms.CheckBox cbWSHTTP;
        private System.Windows.Forms.CheckBox cbMEX;
        private System.Windows.Forms.CheckBox cbBSHTTP;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RichTextBox txtStatus;
    }
}

