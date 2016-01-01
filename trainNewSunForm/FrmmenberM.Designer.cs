namespace trainNewSun
{
    partial class FrmmenberM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmmenberM));
            this.btDele = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxmain = new System.Windows.Forms.GroupBox();
            this.cbxsch = new System.Windows.Forms.ComboBox();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.dateAddDate = new System.Windows.Forms.DateTimePicker();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxUway = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxValid = new System.Windows.Forms.ComboBox();
            this.tbxclass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxChineseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labUserNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.gbxmain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.btDele.Click += new System.EventHandler(this.btDele_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "成员状态";
            // 
            // gbxmain
            // 
            this.gbxmain.Controls.Add(this.cbxsch);
            this.gbxmain.Controls.Add(this.cbxCourse);
            this.gbxmain.Controls.Add(this.dateAddDate);
            this.gbxmain.Controls.Add(this.cbxSex);
            this.gbxmain.Controls.Add(this.cbxUway);
            this.gbxmain.Controls.Add(this.label9);
            this.gbxmain.Controls.Add(this.label10);
            this.gbxmain.Controls.Add(this.label7);
            this.gbxmain.Controls.Add(this.tbxMobile);
            this.gbxmain.Controls.Add(this.label8);
            this.gbxmain.Controls.Add(this.label6);
            this.gbxmain.Controls.Add(this.cbxValid);
            this.gbxmain.Controls.Add(this.tbxclass);
            this.gbxmain.Controls.Add(this.label5);
            this.gbxmain.Controls.Add(this.label4);
            this.gbxmain.Controls.Add(this.tbxChineseName);
            this.gbxmain.Controls.Add(this.label2);
            this.gbxmain.Controls.Add(this.labUserNo);
            this.gbxmain.Controls.Add(this.label1);
            this.gbxmain.Controls.Add(this.label3);
            this.gbxmain.Location = new System.Drawing.Point(6, 72);
            this.gbxmain.Name = "gbxmain";
            this.gbxmain.Size = new System.Drawing.Size(430, 156);
            this.gbxmain.TabIndex = 43;
            this.gbxmain.TabStop = false;
            this.gbxmain.Text = "成员编辑";
            // 
            // cbxsch
            // 
            this.cbxsch.BackColor = System.Drawing.Color.White;
            this.cbxsch.FormattingEnabled = true;
            this.cbxsch.Items.AddRange(new object[] {
            "兴宁一中",
            "田家炳中学",
            "沐彬中学",
            "兴民中学",
            "实验学校",
            "宁江中学",
            "第二中学",
            "第三中学",
            "佛岭小学",
            "其他学校"});
            this.cbxsch.Location = new System.Drawing.Point(69, 72);
            this.cbxsch.Name = "cbxsch";
            this.cbxsch.Size = new System.Drawing.Size(147, 20);
            this.cbxsch.TabIndex = 40;
            // 
            // cbxCourse
            // 
            this.cbxCourse.BackColor = System.Drawing.Color.White;
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(287, 99);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(137, 20);
            this.cbxCourse.TabIndex = 39;
            // 
            // dateAddDate
            // 
            this.dateAddDate.CustomFormat = "";
            this.dateAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddDate.Location = new System.Drawing.Point(69, 125);
            this.dateAddDate.Name = "dateAddDate";
            this.dateAddDate.Size = new System.Drawing.Size(147, 21);
            this.dateAddDate.TabIndex = 38;
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxSex.Location = new System.Drawing.Point(286, 44);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(136, 20);
            this.cbxSex.TabIndex = 37;
            // 
            // cbxUway
            // 
            this.cbxUway.FormattingEnabled = true;
            this.cbxUway.Items.AddRange(new object[] {
            "报纸传单",
            "他人介绍",
            "附近居住",
            "互联网"});
            this.cbxUway.Location = new System.Drawing.Point(286, 125);
            this.cbxUway.Name = "cbxUway";
            this.cbxUway.Size = new System.Drawing.Size(138, 20);
            this.cbxUway.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "报名途径";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "报名时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "课    程";
            // 
            // tbxMobile
            // 
            this.tbxMobile.Location = new System.Drawing.Point(69, 98);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(147, 21);
            this.tbxMobile.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "手    机";
            // 
            // cbxValid
            // 
            this.cbxValid.FormattingEnabled = true;
            this.cbxValid.Items.AddRange(new object[] {
            "启用中",
            "失效中"});
            this.cbxValid.Location = new System.Drawing.Point(286, 15);
            this.cbxValid.Name = "cbxValid";
            this.cbxValid.Size = new System.Drawing.Size(136, 20);
            this.cbxValid.TabIndex = 27;
            // 
            // tbxclass
            // 
            this.tbxclass.Location = new System.Drawing.Point(286, 71);
            this.tbxclass.Name = "tbxclass";
            this.tbxclass.Size = new System.Drawing.Size(136, 21);
            this.tbxclass.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "班    级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "学    校";
            // 
            // tbxChineseName
            // 
            this.tbxChineseName.Location = new System.Drawing.Point(69, 44);
            this.tbxChineseName.Name = "tbxChineseName";
            this.tbxChineseName.Size = new System.Drawing.Size(147, 21);
            this.tbxChineseName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "性    别";
            // 
            // labUserNo
            // 
            this.labUserNo.AutoSize = true;
            this.labUserNo.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserNo.Location = new System.Drawing.Point(85, 18);
            this.labUserNo.Name = "labUserNo";
            this.labUserNo.Size = new System.Drawing.Size(63, 14);
            this.labUserNo.TabIndex = 20;
            this.labUserNo.Text = "U000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "成员编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "成员姓名";
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
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.toolStripSeparator3,
            this.btSave,
            this.toolStripSeparator2,
            this.btDele,
            this.toolStripSeparator1,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 67);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
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
            // FrmmenberM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(442, 233);
            this.Controls.Add(this.gbxmain);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmmenberM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成员编辑";
            this.gbxmain.ResumeLayout(false);
            this.gbxmain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btDele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxmain;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxUway;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxValid;
        private System.Windows.Forms.TextBox tbxclass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxChineseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labUserNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.DateTimePicker dateAddDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.ComboBox cbxsch;
    }
}