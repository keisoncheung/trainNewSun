namespace trainNewSun
{
    partial class FrmAboutUs
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.labSofeName = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.linlabAuthorEmail = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "软件版本：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linlabAuthorEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labVersion);
            this.groupBox1.Controls.Add(this.labSofeName);
            this.groupBox1.Controls.Add(this.labAuthor);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 88);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关于软件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "软件名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "软件开发者：";
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.Location = new System.Drawing.Point(89, 40);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(11, 12);
            this.labVersion.TabIndex = 2;
            this.labVersion.Text = "2";
            // 
            // labSofeName
            // 
            this.labSofeName.AutoSize = true;
            this.labSofeName.Location = new System.Drawing.Point(89, 17);
            this.labSofeName.Name = "labSofeName";
            this.labSofeName.Size = new System.Drawing.Size(11, 12);
            this.labSofeName.TabIndex = 1;
            this.labSofeName.Text = "1";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(89, 63);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(11, 12);
            this.labAuthor.TabIndex = 0;
            this.labAuthor.Text = "3";
            // 
            // linlabAuthorEmail
            // 
            this.linlabAuthorEmail.AutoSize = true;
            this.linlabAuthorEmail.Location = new System.Drawing.Point(160, 63);
            this.linlabAuthorEmail.Name = "linlabAuthorEmail";
            this.linlabAuthorEmail.Size = new System.Drawing.Size(53, 12);
            this.linlabAuthorEmail.TabIndex = 11;
            this.linlabAuthorEmail.TabStop = true;
            this.linlabAuthorEmail.Text = "联系作者";
            this.linlabAuthorEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlabAuthorEmail_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copy Right© 2012";
            // 
            // FrmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(272, 119);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "FrmAboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于软件与作者";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.Label labSofeName;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.LinkLabel linlabAuthorEmail;
        private System.Windows.Forms.Label label5;

    }
}