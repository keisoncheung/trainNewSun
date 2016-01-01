namespace trainNewSun
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btQuit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(269, 94);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(80, 32);
            this.btQuit.TabIndex = 7;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(183, 94);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(80, 32);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(183, 67);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.Size = new System.Drawing.Size(168, 21);
            this.tbxPwd.TabIndex = 5;
            this.tbxPwd.UseSystemPasswordChar = true;
            this.tbxPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPwd_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密  码";
            // 
            // tbxUid
            // 
            this.tbxUid.Enabled = false;
            this.tbxUid.Location = new System.Drawing.Point(183, 28);
            this.tbxUid.Name = "tbxUid";
            this.tbxUid.Size = new System.Drawing.Size(168, 21);
            this.tbxUid.TabIndex = 3;
            this.tbxUid.Text = "LZX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btQuit);
            this.gbxLogin.Controls.Add(this.btLogin);
            this.gbxLogin.Controls.Add(this.tbxPwd);
            this.gbxLogin.Controls.Add(this.label2);
            this.gbxLogin.Controls.Add(this.tbxUid);
            this.gbxLogin.Controls.Add(this.label1);
            this.gbxLogin.Controls.Add(this.pictureBox1);
            this.gbxLogin.Location = new System.Drawing.Point(7, 5);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(362, 133);
            this.gbxLogin.TabIndex = 2;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "用户登录";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(376, 143);
            this.Controls.Add(this.gbxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新太阳教育培训机构登录窗口";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbxPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}