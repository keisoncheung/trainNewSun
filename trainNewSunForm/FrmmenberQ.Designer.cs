namespace trainNewSun
{
    partial class FrmmenberQ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmmenberQ));
            this.tbxKeyW = new System.Windows.Forms.TextBox();
            this.cbxCheckAll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.itemCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSigninTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uschool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uqq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uaddtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.tsstorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.tsstorSignin = new System.Windows.Forms.ToolStripSeparator();
            this.btSignin = new System.Windows.Forms.ToolStripButton();
            this.tsstorDel = new System.Windows.Forms.ToolStripSeparator();
            this.btDelte = new System.Windows.Forms.ToolStripButton();
            this.tsstorChoose = new System.Windows.Forms.ToolStripSeparator();
            this.btChoose = new System.Windows.Forms.ToolStripButton();
            this.tsstorClose = new System.Windows.Forms.ToolStripSeparator();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.cbxcourse = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxKeyW
            // 
            this.tbxKeyW.Location = new System.Drawing.Point(212, 78);
            this.tbxKeyW.Name = "tbxKeyW";
            this.tbxKeyW.Size = new System.Drawing.Size(366, 21);
            this.tbxKeyW.TabIndex = 37;
            this.tbxKeyW.TextChanged += new System.EventHandler(this.tbxKeyW_TextChanged);
            this.tbxKeyW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxKeyW_KeyDown);
            // 
            // cbxCheckAll
            // 
            this.cbxCheckAll.AutoSize = true;
            this.cbxCheckAll.Location = new System.Drawing.Point(7, 15);
            this.cbxCheckAll.Name = "cbxCheckAll";
            this.cbxCheckAll.Size = new System.Drawing.Size(48, 16);
            this.cbxCheckAll.TabIndex = 1;
            this.cbxCheckAll.Text = "全选";
            this.cbxCheckAll.UseVisualStyleBackColor = true;
            this.cbxCheckAll.CheckedChanged += new System.EventHandler(this.cbxCheckAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbxCheckAll);
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(4, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 503);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成员资料";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCheck,
            this.colSigninTime,
            this.UserNo,
            this.ChineseName,
            this.Usex,
            this.Valid,
            this.Uschool,
            this.Uclass,
            this.Umobile,
            this.Uqq,
            this.Uaddtime,
            this.Uway});
            this.dgvData.Location = new System.Drawing.Point(6, 32);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1016, 465);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // itemCheck
            // 
            this.itemCheck.HeaderText = "";
            this.itemCheck.Name = "itemCheck";
            this.itemCheck.Width = 20;
            // 
            // colSigninTime
            // 
            this.colSigninTime.HeaderText = "签到时间";
            this.colSigninTime.Name = "colSigninTime";
            this.colSigninTime.Width = 130;
            // 
            // UserNo
            // 
            this.UserNo.HeaderText = "成员编号";
            this.UserNo.Name = "UserNo";
            this.UserNo.ReadOnly = true;
            // 
            // ChineseName
            // 
            this.ChineseName.HeaderText = "姓名";
            this.ChineseName.Name = "ChineseName";
            this.ChineseName.ReadOnly = true;
            // 
            // Usex
            // 
            this.Usex.HeaderText = "性别";
            this.Usex.Name = "Usex";
            this.Usex.ReadOnly = true;
            this.Usex.Width = 40;
            // 
            // Valid
            // 
            this.Valid.HeaderText = "状态";
            this.Valid.Name = "Valid";
            this.Valid.ReadOnly = true;
            this.Valid.Width = 70;
            // 
            // Uschool
            // 
            this.Uschool.HeaderText = "学校";
            this.Uschool.Name = "Uschool";
            this.Uschool.ReadOnly = true;
            // 
            // Uclass
            // 
            this.Uclass.HeaderText = "班级";
            this.Uclass.Name = "Uclass";
            this.Uclass.ReadOnly = true;
            // 
            // Umobile
            // 
            this.Umobile.HeaderText = "联系电话";
            this.Umobile.Name = "Umobile";
            this.Umobile.ReadOnly = true;
            // 
            // Uqq
            // 
            this.Uqq.HeaderText = "课程";
            this.Uqq.Name = "Uqq";
            this.Uqq.ReadOnly = true;
            this.Uqq.Width = 120;
            // 
            // Uaddtime
            // 
            this.Uaddtime.HeaderText = "加入时间";
            this.Uaddtime.Name = "Uaddtime";
            this.Uaddtime.ReadOnly = true;
            // 
            // Uway
            // 
            this.Uway.HeaderText = "报名途径";
            this.Uway.Name = "Uway";
            this.Uway.ReadOnly = true;
            this.Uway.Width = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "关键字搜索";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "(按回车键搜索)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.tsstorEdit,
            this.btEdit,
            this.tsstorDel,
            this.btDelte,
            this.tsstorSignin,
            this.btSignin,
            this.tsstorChoose,
            this.btChoose,
            this.tsstorClose,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 67);
            this.toolStrip1.TabIndex = 39;
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
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tsstorEdit
            // 
            this.tsstorEdit.Name = "tsstorEdit";
            this.tsstorEdit.Size = new System.Drawing.Size(6, 67);
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(52, 64);
            this.btEdit.Text = "修改";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tsstorSignin
            // 
            this.tsstorSignin.Name = "tsstorSignin";
            this.tsstorSignin.Size = new System.Drawing.Size(6, 67);
            // 
            // btSignin
            // 
            this.btSignin.Image = ((System.Drawing.Image)(resources.GetObject("btSignin.Image")));
            this.btSignin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSignin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(52, 64);
            this.btSignin.Text = "签到";
            this.btSignin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            // 
            // tsstorDel
            // 
            this.tsstorDel.Name = "tsstorDel";
            this.tsstorDel.Size = new System.Drawing.Size(6, 67);
            // 
            // btDelte
            // 
            this.btDelte.Image = ((System.Drawing.Image)(resources.GetObject("btDelte.Image")));
            this.btDelte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDelte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelte.Name = "btDelte";
            this.btDelte.Size = new System.Drawing.Size(52, 64);
            this.btDelte.Text = "删除";
            this.btDelte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDelte.Click += new System.EventHandler(this.btDelte_Click);
            // 
            // tsstorChoose
            // 
            this.tsstorChoose.Name = "tsstorChoose";
            this.tsstorChoose.Size = new System.Drawing.Size(6, 67);
            this.tsstorChoose.Visible = false;
            // 
            // btChoose
            // 
            this.btChoose.Image = global::trainNewSun.Properties.Resources.choose;
            this.btChoose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(52, 64);
            this.btChoose.Text = "选择";
            this.btChoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btChoose.Visible = false;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // tsstorClose
            // 
            this.tsstorClose.Name = "tsstorClose";
            this.tsstorClose.Size = new System.Drawing.Size(6, 67);
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
            // cbxcourse
            // 
            this.cbxcourse.FormattingEnabled = true;
            this.cbxcourse.Location = new System.Drawing.Point(85, 79);
            this.cbxcourse.Name = "cbxcourse";
            this.cbxcourse.Size = new System.Drawing.Size(121, 20);
            this.cbxcourse.TabIndex = 40;
            this.cbxcourse.SelectedIndexChanged += new System.EventHandler(this.cbxcourse_SelectedIndexChanged);
            // 
            // FrmmenberQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 606);
            this.Controls.Add(this.cbxcourse);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKeyW);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Name = "FrmmenberQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成员管理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKeyW;
        private System.Windows.Forms.CheckBox cbxCheckAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btDelte;
        private System.Windows.Forms.ToolStripButton btChoose;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ToolStripSeparator tsstorEdit;
        private System.Windows.Forms.ToolStripSeparator tsstorDel;
        private System.Windows.Forms.ToolStripSeparator tsstorChoose;
        private System.Windows.Forms.ToolStripSeparator tsstorClose;
        private System.Windows.Forms.ComboBox cbxcourse;
        private System.Windows.Forms.ToolStripSeparator tsstorSignin;
        private System.Windows.Forms.ToolStripButton btSignin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSigninTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uschool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uqq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uaddtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uway;
    }
}