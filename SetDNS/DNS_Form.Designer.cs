namespace SetDNS
{
    partial class DNS_Form
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
            this.btnCleanBrowsing = new System.Windows.Forms.Button();
            this.btn403 = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnShecan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFlushDns = new System.Windows.Forms.Button();
            this.btnShowDNS = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.lblBehzad = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCleanBrowsing);
            this.groupBox1.Controls.Add(this.btn403);
            this.groupBox1.Controls.Add(this.btnOne);
            this.groupBox1.Controls.Add(this.btnGoogle);
            this.groupBox1.Controls.Add(this.btnShecan);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNS Servers";
            // 
            // btnCleanBrowsing
            // 
            this.btnCleanBrowsing.Location = new System.Drawing.Point(19, 181);
            this.btnCleanBrowsing.Name = "btnCleanBrowsing";
            this.btnCleanBrowsing.Size = new System.Drawing.Size(82, 30);
            this.btnCleanBrowsing.TabIndex = 11;
            this.btnCleanBrowsing.Text = "CleanBrowsing";
            this.btnCleanBrowsing.UseVisualStyleBackColor = true;
            this.btnCleanBrowsing.Click += new System.EventHandler(this.btnCleanBrowsing_Click);
            // 
            // btn403
            // 
            this.btn403.Location = new System.Drawing.Point(19, 29);
            this.btn403.Name = "btn403";
            this.btn403.Size = new System.Drawing.Size(82, 31);
            this.btn403.TabIndex = 10;
            this.btn403.Text = "403";
            this.btn403.UseVisualStyleBackColor = true;
            this.btn403.Click += new System.EventHandler(this.btn403_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(19, 142);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(82, 30);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1.1.1.1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            this.btnOne.StyleChanged += new System.EventHandler(this.btnOne_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(19, 105);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(82, 31);
            this.btnGoogle.TabIndex = 8;
            this.btnGoogle.Text = "Set Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            this.btnGoogle.StyleChanged += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnShecan
            // 
            this.btnShecan.Location = new System.Drawing.Point(19, 66);
            this.btnShecan.Name = "btnShecan";
            this.btnShecan.Size = new System.Drawing.Size(82, 33);
            this.btnShecan.TabIndex = 7;
            this.btnShecan.Text = "Set Shecan";
            this.btnShecan.UseVisualStyleBackColor = true;
            this.btnShecan.Click += new System.EventHandler(this.btnShecan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFlushDns);
            this.groupBox2.Controls.Add(this.btnShowDNS);
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Location = new System.Drawing.Point(162, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 235);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnFlushDns
            // 
            this.btnFlushDns.Location = new System.Drawing.Point(19, 106);
            this.btnFlushDns.Name = "btnFlushDns";
            this.btnFlushDns.Size = new System.Drawing.Size(82, 30);
            this.btnFlushDns.TabIndex = 8;
            this.btnFlushDns.Text = "Flush DNS";
            this.btnFlushDns.UseVisualStyleBackColor = true;
            this.btnFlushDns.Click += new System.EventHandler(this.btnFlushDns_Click);
            // 
            // btnShowDNS
            // 
            this.btnShowDNS.Location = new System.Drawing.Point(19, 30);
            this.btnShowDNS.Name = "btnShowDNS";
            this.btnShowDNS.Size = new System.Drawing.Size(82, 30);
            this.btnShowDNS.TabIndex = 7;
            this.btnShowDNS.Text = "Show DNS";
            this.btnShowDNS.UseVisualStyleBackColor = true;
            this.btnShowDNS.Click += new System.EventHandler(this.btnShowDNS_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(19, 68);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 31);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear DNS";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lblBehzad
            // 
            this.lblBehzad.AutoSize = true;
            this.lblBehzad.Location = new System.Drawing.Point(12, 260);
            this.lblBehzad.Name = "lblBehzad";
            this.lblBehzad.Size = new System.Drawing.Size(124, 13);
            this.lblBehzad.TabIndex = 9;
            this.lblBehzad.Text = "Behzad Bagheri Behrooz";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(144, 260);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(147, 13);
            this.githubLink.TabIndex = 10;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/behzadbb";
            // 
            // DNS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 284);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.lblBehzad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DNS_Form";
            this.Text = "DNS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn403;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnShecan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFlushDns;
        private System.Windows.Forms.Button btnShowDNS;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btnCleanBrowsing;
        private System.Windows.Forms.Label lblBehzad;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}

