namespace trainNewSun
{
    partial class FrmSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMS));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btAutoSend = new System.Windows.Forms.ToolStripButton();
            this.btGetNums = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.itemCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddUM = new System.Windows.Forms.Button();
            this.bt_Del = new System.Windows.Forms.Button();
            this.cbxCheckAll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAddHM = new System.Windows.Forms.Button();
            this.bt_Del2 = new System.Windows.Forms.Button();
            this.cbxCheckAll2 = new System.Windows.Forms.CheckBox();
            this.dgvData3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxphonesUnder = new System.Windows.Forms.TextBox();
            this.dgvData2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave,
            this.btAutoSend,
            this.btGetNums,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(979, 67);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 64);
            this.btSave.Text = "发送";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAutoSend
            // 
            this.btAutoSend.Enabled = false;
            this.btAutoSend.Image = global::trainNewSun.Properties.Resources.save;
            this.btAutoSend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAutoSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAutoSend.Name = "btAutoSend";
            this.btAutoSend.Size = new System.Drawing.Size(81, 64);
            this.btAutoSend.Text = "发送未发短信";
            this.btAutoSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAutoSend.Visible = false;
            this.btAutoSend.Click += new System.EventHandler(this.btAutoSend_Click);
            // 
            // btGetNums
            // 
            this.btGetNums.Image = ((System.Drawing.Image)(resources.GetObject("btGetNums.Image")));
            this.btGetNums.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btGetNums.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGetNums.Name = "btGetNums";
            this.btGetNums.Size = new System.Drawing.Size(105, 64);
            this.btGetNums.Text = "获取短信剩余数量";
            this.btGetNums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGetNums.Click += new System.EventHandler(this.btGetNums_Click);
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
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCheck,
            this.ChineseName,
            this.Umobile});
            this.dgvData.Location = new System.Drawing.Point(6, 38);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(251, 385);
            this.dgvData.TabIndex = 43;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            // 
            // itemCheck
            // 
            this.itemCheck.HeaderText = "";
            this.itemCheck.Name = "itemCheck";
            this.itemCheck.Width = 20;
            // 
            // ChineseName
            // 
            this.ChineseName.HeaderText = "姓名";
            this.ChineseName.Name = "ChineseName";
            // 
            // Umobile
            // 
            this.Umobile.HeaderText = "联系电话";
            this.Umobile.Name = "Umobile";
            this.Umobile.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btAddUM);
            this.groupBox1.Controls.Add(this.bt_Del);
            this.groupBox1.Controls.Add(this.cbxCheckAll);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 429);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "号码列表";
            // 
            // btAddUM
            // 
            this.btAddUM.Location = new System.Drawing.Point(145, 13);
            this.btAddUM.Name = "btAddUM";
            this.btAddUM.Size = new System.Drawing.Size(53, 21);
            this.btAddUM.TabIndex = 47;
            this.btAddUM.Text = "导入";
            this.btAddUM.UseVisualStyleBackColor = true;
            this.btAddUM.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // bt_Del
            // 
            this.bt_Del.Location = new System.Drawing.Point(204, 13);
            this.bt_Del.Name = "bt_Del";
            this.bt_Del.Size = new System.Drawing.Size(53, 21);
            this.bt_Del.TabIndex = 46;
            this.bt_Del.Text = "移除";
            this.bt_Del.UseVisualStyleBackColor = true;
            this.bt_Del.Click += new System.EventHandler(this.bt_Del_Click);
            // 
            // cbxCheckAll
            // 
            this.cbxCheckAll.AutoSize = true;
            this.cbxCheckAll.Location = new System.Drawing.Point(6, 16);
            this.cbxCheckAll.Name = "cbxCheckAll";
            this.cbxCheckAll.Size = new System.Drawing.Size(48, 16);
            this.cbxCheckAll.TabIndex = 45;
            this.cbxCheckAll.Text = "全选";
            this.cbxCheckAll.UseVisualStyleBackColor = true;
            this.cbxCheckAll.CheckedChanged += new System.EventHandler(this.cbxCheckAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxContent);
            this.groupBox2.Location = new System.Drawing.Point(554, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 429);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "要发送的短信内容";
            // 
            // tbxContent
            // 
            this.tbxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxContent.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbxContent.Location = new System.Drawing.Point(6, 40);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.Size = new System.Drawing.Size(386, 383);
            this.tbxContent.TabIndex = 48;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 466);
            this.tabControl1.TabIndex = 47;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送短信";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btAddHM);
            this.groupBox3.Controls.Add(this.bt_Del2);
            this.groupBox3.Controls.Add(this.cbxCheckAll2);
            this.groupBox3.Controls.Add(this.dgvData3);
            this.groupBox3.Location = new System.Drawing.Point(282, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 429);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他成员号码列表";
            // 
            // btAddHM
            // 
            this.btAddHM.Location = new System.Drawing.Point(145, 13);
            this.btAddHM.Name = "btAddHM";
            this.btAddHM.Size = new System.Drawing.Size(53, 21);
            this.btAddHM.TabIndex = 48;
            this.btAddHM.Text = "导入";
            this.btAddHM.UseVisualStyleBackColor = true;
            this.btAddHM.Click += new System.EventHandler(this.btAddHM_Click);
            // 
            // bt_Del2
            // 
            this.bt_Del2.Location = new System.Drawing.Point(204, 13);
            this.bt_Del2.Name = "bt_Del2";
            this.bt_Del2.Size = new System.Drawing.Size(53, 21);
            this.bt_Del2.TabIndex = 46;
            this.bt_Del2.Text = "移除";
            this.bt_Del2.UseVisualStyleBackColor = true;
            this.bt_Del2.Click += new System.EventHandler(this.bt_Del2_Click);
            // 
            // cbxCheckAll2
            // 
            this.cbxCheckAll2.AutoSize = true;
            this.cbxCheckAll2.Location = new System.Drawing.Point(6, 16);
            this.cbxCheckAll2.Name = "cbxCheckAll2";
            this.cbxCheckAll2.Size = new System.Drawing.Size(48, 16);
            this.cbxCheckAll2.TabIndex = 45;
            this.cbxCheckAll2.Text = "全选";
            this.cbxCheckAll2.UseVisualStyleBackColor = true;
            this.cbxCheckAll2.CheckedChanged += new System.EventHandler(this.cbxCheckAll2_CheckedChanged);
            // 
            // dgvData3
            // 
            this.dgvData3.AllowUserToAddRows = false;
            this.dgvData3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvData3.Location = new System.Drawing.Point(6, 40);
            this.dgvData3.Name = "dgvData3";
            this.dgvData3.RowHeadersVisible = false;
            this.dgvData3.RowTemplate.Height = 23;
            this.dgvData3.Size = new System.Drawing.Size(251, 383);
            this.dgvData3.TabIndex = 43;
            this.dgvData3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData3_CellClick);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "联系电话";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbxphonesUnder);
            this.tabPage2.Controls.Add(this.dgvData2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "短信记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "号码明细";
            // 
            // tbxphonesUnder
            // 
            this.tbxphonesUnder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxphonesUnder.Location = new System.Drawing.Point(7, 318);
            this.tbxphonesUnder.Multiline = true;
            this.tbxphonesUnder.Name = "tbxphonesUnder";
            this.tbxphonesUnder.Size = new System.Drawing.Size(945, 117);
            this.tbxphonesUnder.TabIndex = 45;
            // 
            // dgvData2
            // 
            this.dgvData2.AllowUserToAddRows = false;
            this.dgvData2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.title,
            this.createtime});
            this.dgvData2.Location = new System.Drawing.Point(6, 6);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.RowHeadersVisible = false;
            this.dgvData2.RowTemplate.Height = 23;
            this.dgvData2.Size = new System.Drawing.Size(946, 289);
            this.dgvData2.TabIndex = 44;
            this.dgvData2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData2_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // title
            // 
            this.title.HeaderText = "短信内容";
            this.title.Name = "title";
            this.title.Width = 700;
            // 
            // createtime
            // 
            this.createtime.HeaderText = "时间";
            this.createtime.Name = "createtime";
            this.createtime.ReadOnly = true;
            this.createtime.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "(60个字一条短信)";
            // 
            // FrmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "短信平台";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btGetNums;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btAutoSend;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.CheckBox cbxCheckAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxphonesUnder;
        private System.Windows.Forms.DataGridView dgvData2;
        private System.Windows.Forms.Button bt_Del;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Del2;
        private System.Windows.Forms.CheckBox cbxCheckAll2;
        private System.Windows.Forms.DataGridView dgvData3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btAddUM;
        private System.Windows.Forms.Button btAddHM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
        private System.Windows.Forms.Label label1;
    }
}