namespace trainNewSun
{
    partial class FrmTrainee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrainee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btCollections = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddCourse = new System.Windows.Forms.Button();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labPayMeny = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPayMonent = new System.Windows.Forms.TextBox();
            this.datePayTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labClassNums = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labAmountTotal = new System.Windows.Forms.Label();
            this.cbxCheckAll = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.itemCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.classNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData2 = new System.Windows.Forms.DataGridView();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uschool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Umobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uaddtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSearch,
            this.toolStripSeparator3,
            this.btSave,
            this.toolStripSeparator4,
            this.btStart,
            this.toolStripSeparator2,
            this.btCollections,
            this.toolStripSeparator5,
            this.btDelete,
            this.toolStripSeparator1,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 67);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btSearch
            // 
            this.btSearch.Image = global::trainNewSun.Properties.Resources.find;
            this.btSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(52, 64);
            this.btSearch.Text = "搜索";
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Image = global::trainNewSun.Properties.Resources.save;
            this.btSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 64);
            this.btSave.Text = "保存";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 67);
            // 
            // btStart
            // 
            this.btStart.Enabled = false;
            this.btStart.Image = global::trainNewSun.Properties.Resources._new;
            this.btStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(57, 64);
            this.btStart.Text = "上课登记";
            this.btStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            // 
            // btCollections
            // 
            this.btCollections.Enabled = false;
            this.btCollections.Image = global::trainNewSun.Properties.Resources.audit;
            this.btCollections.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btCollections.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCollections.Name = "btCollections";
            this.btCollections.Size = new System.Drawing.Size(52, 64);
            this.btCollections.Text = "收款";
            this.btCollections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCollections.Click += new System.EventHandler(this.btCollections_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btAddCourse);
            this.groupBox1.Controls.Add(this.cbxCourse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 45);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // btAddCourse
            // 
            this.btAddCourse.Location = new System.Drawing.Point(208, 16);
            this.btAddCourse.Name = "btAddCourse";
            this.btAddCourse.Size = new System.Drawing.Size(26, 23);
            this.btAddCourse.TabIndex = 73;
            this.btAddCourse.Text = "..";
            this.btAddCourse.UseVisualStyleBackColor = true;
            this.btAddCourse.Click += new System.EventHandler(this.btAddCourse_Click);
            // 
            // cbxCourse
            // 
            this.cbxCourse.BackColor = System.Drawing.Color.White;
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(65, 18);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(137, 20);
            this.cbxCourse.TabIndex = 29;
            this.cbxCourse.SelectedIndexChanged += new System.EventHandler(this.cbxCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名称";
            // 
            // labPayMeny
            // 
            this.labPayMeny.AutoSize = true;
            this.labPayMeny.BackColor = System.Drawing.Color.White;
            this.labPayMeny.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labPayMeny.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPayMeny.ForeColor = System.Drawing.Color.Red;
            this.labPayMeny.Location = new System.Drawing.Point(84, 81);
            this.labPayMeny.Name = "labPayMeny";
            this.labPayMeny.Size = new System.Drawing.Size(14, 14);
            this.labPayMeny.TabIndex = 78;
            this.labPayMeny.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 75;
            this.label6.Text = "已收总金额";
            // 
            // tbxPayMonent
            // 
            this.tbxPayMonent.Location = new System.Drawing.Point(84, 106);
            this.tbxPayMonent.Name = "tbxPayMonent";
            this.tbxPayMonent.Size = new System.Drawing.Size(116, 21);
            this.tbxPayMonent.TabIndex = 72;
            this.tbxPayMonent.Text = "0";
            // 
            // datePayTime
            // 
            this.datePayTime.CustomFormat = "";
            this.datePayTime.Location = new System.Drawing.Point(84, 133);
            this.datePayTime.Name = "datePayTime";
            this.datePayTime.Size = new System.Drawing.Size(116, 21);
            this.datePayTime.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = "收款日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 64;
            this.label7.Text = "本次收金额";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbxCheckAll);
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(5, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 361);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上课登记详情";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.labClassNums);
            this.groupBox3.Controls.Add(this.labPayMeny);
            this.groupBox3.Controls.Add(this.tbxPayMonent);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.datePayTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labAmountTotal);
            this.groupBox3.Location = new System.Drawing.Point(464, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 317);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 74;
            this.label2.Text = "上课总节数";
            // 
            // labClassNums
            // 
            this.labClassNums.AutoSize = true;
            this.labClassNums.BackColor = System.Drawing.Color.White;
            this.labClassNums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labClassNums.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClassNums.ForeColor = System.Drawing.Color.Red;
            this.labClassNums.Location = new System.Drawing.Point(84, 20);
            this.labClassNums.Name = "labClassNums";
            this.labClassNums.Size = new System.Drawing.Size(14, 14);
            this.labClassNums.TabIndex = 75;
            this.labClassNums.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 72;
            this.label5.Text = "应收总金额";
            // 
            // labAmountTotal
            // 
            this.labAmountTotal.AutoSize = true;
            this.labAmountTotal.BackColor = System.Drawing.Color.White;
            this.labAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAmountTotal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAmountTotal.ForeColor = System.Drawing.Color.Red;
            this.labAmountTotal.Location = new System.Drawing.Point(84, 52);
            this.labAmountTotal.Name = "labAmountTotal";
            this.labAmountTotal.Size = new System.Drawing.Size(14, 14);
            this.labAmountTotal.TabIndex = 73;
            this.labAmountTotal.Text = "0";
            // 
            // cbxCheckAll
            // 
            this.cbxCheckAll.AutoSize = true;
            this.cbxCheckAll.Location = new System.Drawing.Point(6, 21);
            this.cbxCheckAll.Name = "cbxCheckAll";
            this.cbxCheckAll.Size = new System.Drawing.Size(48, 16);
            this.cbxCheckAll.TabIndex = 76;
            this.cbxCheckAll.Text = "全选";
            this.cbxCheckAll.UseVisualStyleBackColor = true;
            this.cbxCheckAll.CheckedChanged += new System.EventHandler(this.cbxCheckAll_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCheck,
            this.classNum,
            this.startTime,
            this.amount,
            this.isFinish});
            this.dgvData.Location = new System.Drawing.Point(6, 43);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(452, 310);
            this.dgvData.TabIndex = 52;
            this.dgvData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseClick);
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellValueChanged);
            // 
            // itemCheck
            // 
            this.itemCheck.HeaderText = "";
            this.itemCheck.Name = "itemCheck";
            this.itemCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCheck.Width = 20;
            // 
            // classNum
            // 
            this.classNum.HeaderText = "课时数";
            this.classNum.Name = "classNum";
            this.classNum.ReadOnly = true;
            this.classNum.Width = 80;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "开始时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 120;
            // 
            // amount
            // 
            this.amount.HeaderText = "应收金额";
            this.amount.Name = "amount";
            // 
            // isFinish
            // 
            this.isFinish.HeaderText = "状态";
            this.isFinish.Name = "isFinish";
            // 
            // dgvData2
            // 
            this.dgvData2.AllowUserToAddRows = false;
            this.dgvData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNo,
            this.ChineseName,
            this.Usex,
            this.Uschool,
            this.Uclass,
            this.Umobile,
            this.Uaddtime});
            this.dgvData2.Location = new System.Drawing.Point(5, 119);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.RowHeadersVisible = false;
            this.dgvData2.RowTemplate.Height = 23;
            this.dgvData2.Size = new System.Drawing.Size(686, 212);
            this.dgvData2.TabIndex = 79;
            this.dgvData2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData2_CellClick);
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
            // Uaddtime
            // 
            this.Uaddtime.HeaderText = "加入时间";
            this.Uaddtime.Name = "Uaddtime";
            this.Uaddtime.ReadOnly = true;
            this.Uaddtime.Width = 140;
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(52, 64);
            this.btDelete.Text = "删除";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 67);
            // 
            // FrmTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 701);
            this.Controls.Add(this.dgvData2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTrainee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrainee";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btCollections;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labPayMeny;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddCourse;
        private System.Windows.Forms.TextBox tbxPayMonent;
        private System.Windows.Forms.DateTimePicker datePayTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labClassNums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label labAmountTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxCheckAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFinish;
        private System.Windows.Forms.DataGridView dgvData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uschool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Umobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uaddtime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btDelete;
    }
}