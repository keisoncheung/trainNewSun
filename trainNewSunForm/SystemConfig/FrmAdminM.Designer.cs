namespace trainNewSun.SystemConfig
{
    partial class FrmAdminM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminM));
            this.label6 = new System.Windows.Forms.Label();
            this.cbxValid = new System.Windows.Forms.ComboBox();
            this.tbxPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btDele = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.tbxChineseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labUserNo = new System.Windows.Forms.Label();
            this.tbxLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxAcountpwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxsmsContent = new System.Windows.Forms.TextBox();
            this.labSMS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxA_money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "账号状态";
            // 
            // cbxValid
            // 
            this.cbxValid.Enabled = false;
            this.cbxValid.FormattingEnabled = true;
            this.cbxValid.Items.AddRange(new object[] {
            "启用中",
            "失效中"});
            this.cbxValid.Location = new System.Drawing.Point(286, 15);
            this.cbxValid.Name = "cbxValid";
            this.cbxValid.Size = new System.Drawing.Size(136, 20);
            this.cbxValid.TabIndex = 27;
            // 
            // tbxPassword2
            // 
            this.tbxPassword2.Location = new System.Drawing.Point(286, 72);
            this.tbxPassword2.Name = "tbxPassword2";
            this.tbxPassword2.Size = new System.Drawing.Size(136, 21);
            this.tbxPassword2.TabIndex = 26;
            this.tbxPassword2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "确认密码";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(69, 72);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(147, 21);
            this.tbxPassword.TabIndex = 24;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "登录密码";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btSave,
            this.btDele,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 67);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(52, 64);
            this.btAdd.Text = "增加";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 64);
            this.btSave.Text = "保存";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDele
            // 
            this.btDele.Image = ((System.Drawing.Image)(resources.GetObject("btDele.Image")));
            this.btDele.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDele.Name = "btDele";
            this.btDele.Size = new System.Drawing.Size(52, 64);
            this.btDele.Text = "删除";
            this.btDele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDele.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(52, 64);
            this.btClose.Text = "关闭";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tbxChineseName
            // 
            this.tbxChineseName.Location = new System.Drawing.Point(286, 42);
            this.tbxChineseName.Name = "tbxChineseName";
            this.tbxChineseName.Size = new System.Drawing.Size(136, 21);
            this.tbxChineseName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "真实姓名";
            // 
            // labUserNo
            // 
            this.labUserNo.AutoSize = true;
            this.labUserNo.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserNo.Location = new System.Drawing.Point(85, 18);
            this.labUserNo.Name = "labUserNo";
            this.labUserNo.Size = new System.Drawing.Size(63, 14);
            this.labUserNo.TabIndex = 20;
            this.labUserNo.Text = "A000001";
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.Location = new System.Drawing.Point(69, 42);
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.Size = new System.Drawing.Size(147, 21);
            this.tbxLoginName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "管理员编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "登录名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAcountpwd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxsmsContent);
            this.groupBox1.Controls.Add(this.labSMS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxA_money);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxValid);
            this.groupBox1.Controls.Add(this.tbxPassword2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxChineseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labUserNo);
            this.groupBox1.Controls.Add(this.tbxLoginName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 234);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户编辑";
            // 
            // tbxAcountpwd
            // 
            this.tbxAcountpwd.Location = new System.Drawing.Point(286, 101);
            this.tbxAcountpwd.Name = "tbxAcountpwd";
            this.tbxAcountpwd.Size = new System.Drawing.Size(136, 21);
            this.tbxAcountpwd.TabIndex = 36;
            this.tbxAcountpwd.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "财务密码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "新增成员通知内容";
            // 
            // tbxsmsContent
            // 
            this.tbxsmsContent.Location = new System.Drawing.Point(12, 155);
            this.tbxsmsContent.Multiline = true;
            this.tbxsmsContent.Name = "tbxsmsContent";
            this.tbxsmsContent.Size = new System.Drawing.Size(410, 72);
            this.tbxsmsContent.TabIndex = 33;
            // 
            // labSMS
            // 
            this.labSMS.AutoSize = true;
            this.labSMS.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSMS.Location = new System.Drawing.Point(73, 135);
            this.labSMS.Name = "labSMS";
            this.labSMS.Size = new System.Drawing.Size(39, 14);
            this.labSMS.TabIndex = 32;
            this.labSMS.Text = "8888";
            this.labSMS.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "短信余额";
            this.label8.Visible = false;
            // 
            // tbxA_money
            // 
            this.tbxA_money.Location = new System.Drawing.Point(69, 101);
            this.tbxA_money.Name = "tbxA_money";
            this.tbxA_money.Size = new System.Drawing.Size(147, 21);
            this.tbxA_money.TabIndex = 30;
            this.tbxA_money.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "原始余额";
            // 
            // FrmAdminM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(442, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmAdminM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员编辑";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxValid;
        private System.Windows.Forms.TextBox tbxPassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btDele;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.TextBox tbxChineseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labUserNo;
        private System.Windows.Forms.TextBox tbxLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxA_money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labSMS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxsmsContent;
        private System.Windows.Forms.TextBox tbxAcountpwd;
        private System.Windows.Forms.Label label11;
    }
}