namespace trainNewSun
{
    partial class FrmIncomeQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncomeQ));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btColse = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCashInB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labCashOutB = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labTotalCC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpIncome = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.itemCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountsIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountsOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icometype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imenber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new System.Windows.Forms.Button();
            this.createDateTimeE = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createDateTimeS = new System.Windows.Forms.DateTimePicker();
            this.tbp = new System.Windows.Forms.TabPage();
            this.btSearch2 = new System.Windows.Forms.Button();
            this.createDateTimeE2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createDateTimeS2 = new System.Windows.Forms.DateTimePicker();
            this.dgvData2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labCashInS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labCashOutS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labCashInS2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labCashOutS2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btColse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 67);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btColse
            // 
            this.btColse.Image = ((System.Drawing.Image)(resources.GetObject("btColse.Image")));
            this.btColse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btColse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btColse.Name = "btColse";
            this.btColse.Size = new System.Drawing.Size(52, 64);
            this.btColse.Text = "关闭";
            this.btColse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btColse.Click += new System.EventHandler(this.btColse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labCashInB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labCashOutB);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labTotalCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(5, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 543);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "现金流详情";
            // 
            // labCashInB
            // 
            this.labCashInB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashInB.AutoSize = true;
            this.labCashInB.BackColor = System.Drawing.Color.White;
            this.labCashInB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashInB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashInB.ForeColor = System.Drawing.Color.Red;
            this.labCashInB.Location = new System.Drawing.Point(382, 523);
            this.labCashInB.Name = "labCashInB";
            this.labCashInB.Size = new System.Drawing.Size(14, 14);
            this.labCashInB.TabIndex = 95;
            this.labCashInB.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(319, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 94;
            this.label8.Text = "总收入：";
            // 
            // labCashOutB
            // 
            this.labCashOutB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashOutB.AutoSize = true;
            this.labCashOutB.BackColor = System.Drawing.Color.White;
            this.labCashOutB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashOutB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashOutB.ForeColor = System.Drawing.Color.Red;
            this.labCashOutB.Location = new System.Drawing.Point(594, 523);
            this.labCashOutB.Name = "labCashOutB";
            this.labCashOutB.Size = new System.Drawing.Size(14, 14);
            this.labCashOutB.TabIndex = 93;
            this.labCashOutB.Text = "0";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(544, 524);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 12);
            this.label15.TabIndex = 92;
            this.label15.Text = "总支出：";
            // 
            // labTotalCC
            // 
            this.labTotalCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labTotalCC.AutoSize = true;
            this.labTotalCC.BackColor = System.Drawing.Color.White;
            this.labTotalCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotalCC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotalCC.ForeColor = System.Drawing.Color.Red;
            this.labTotalCC.Location = new System.Drawing.Point(139, 522);
            this.labTotalCC.Name = "labTotalCC";
            this.labTotalCC.Size = new System.Drawing.Size(14, 14);
            this.labTotalCC.TabIndex = 79;
            this.labTotalCC.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(63, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "现金余额：";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpIncome);
            this.tabControl1.Controls.Add(this.tbp);
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpIncome
            // 
            this.tbpIncome.Controls.Add(this.labCashInS);
            this.tbpIncome.Controls.Add(this.label6);
            this.tbpIncome.Controls.Add(this.labCashOutS);
            this.tbpIncome.Controls.Add(this.label9);
            this.tbpIncome.Controls.Add(this.dgvData);
            this.tbpIncome.Controls.Add(this.btSearch);
            this.tbpIncome.Controls.Add(this.createDateTimeE);
            this.tbpIncome.Controls.Add(this.label10);
            this.tbpIncome.Controls.Add(this.label1);
            this.tbpIncome.Controls.Add(this.createDateTimeS);
            this.tbpIncome.Location = new System.Drawing.Point(4, 21);
            this.tbpIncome.Name = "tbpIncome";
            this.tbpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncome.Size = new System.Drawing.Size(722, 469);
            this.tbpIncome.TabIndex = 0;
            this.tbpIncome.Text = "现金流";
            this.tbpIncome.UseVisualStyleBackColor = true;
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
            this.createDateTime,
            this.amountsIN,
            this.amountsOUT,
            this.icometype,
            this.imenber,
            this.itest});
            this.dgvData.Location = new System.Drawing.Point(6, 32);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(710, 402);
            this.dgvData.TabIndex = 53;
            // 
            // itemCheck
            // 
            this.itemCheck.HeaderText = "";
            this.itemCheck.Name = "itemCheck";
            this.itemCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemCheck.Visible = false;
            this.itemCheck.Width = 20;
            // 
            // createDateTime
            // 
            this.createDateTime.HeaderText = "时间";
            this.createDateTime.Name = "createDateTime";
            this.createDateTime.ReadOnly = true;
            this.createDateTime.Width = 80;
            // 
            // amountsIN
            // 
            this.amountsIN.HeaderText = "资金流入";
            this.amountsIN.Name = "amountsIN";
            this.amountsIN.ReadOnly = true;
            this.amountsIN.Width = 80;
            // 
            // amountsOUT
            // 
            this.amountsOUT.HeaderText = "资金流出";
            this.amountsOUT.Name = "amountsOUT";
            this.amountsOUT.ReadOnly = true;
            // 
            // icometype
            // 
            this.icometype.HeaderText = "账目类别";
            this.icometype.Name = "icometype";
            this.icometype.ReadOnly = true;
            // 
            // imenber
            // 
            this.imenber.HeaderText = "生意伙伴";
            this.imenber.Name = "imenber";
            this.imenber.ReadOnly = true;
            // 
            // itest
            // 
            this.itest.HeaderText = "备注";
            this.itest.Name = "itest";
            this.itest.ReadOnly = true;
            this.itest.Width = 200;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(339, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 109;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // createDateTimeE
            // 
            this.createDateTimeE.CustomFormat = "";
            this.createDateTimeE.Location = new System.Drawing.Point(217, 6);
            this.createDateTimeE.Name = "createDateTimeE";
            this.createDateTimeE.Size = new System.Drawing.Size(116, 21);
            this.createDateTimeE.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 96;
            this.label10.Text = "查询日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(193, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 98;
            this.label1.Text = "至";
            // 
            // createDateTimeS
            // 
            this.createDateTimeS.CustomFormat = "";
            this.createDateTimeS.Location = new System.Drawing.Point(71, 6);
            this.createDateTimeS.Name = "createDateTimeS";
            this.createDateTimeS.Size = new System.Drawing.Size(116, 21);
            this.createDateTimeS.TabIndex = 97;
            // 
            // tbp
            // 
            this.tbp.Controls.Add(this.labCashInS2);
            this.tbp.Controls.Add(this.label7);
            this.tbp.Controls.Add(this.labCashOutS2);
            this.tbp.Controls.Add(this.label12);
            this.tbp.Controls.Add(this.btSearch2);
            this.tbp.Controls.Add(this.createDateTimeE2);
            this.tbp.Controls.Add(this.label3);
            this.tbp.Controls.Add(this.label5);
            this.tbp.Controls.Add(this.createDateTimeS2);
            this.tbp.Controls.Add(this.dgvData2);
            this.tbp.Location = new System.Drawing.Point(4, 21);
            this.tbp.Name = "tbp";
            this.tbp.Padding = new System.Windows.Forms.Padding(3);
            this.tbp.Size = new System.Drawing.Size(722, 469);
            this.tbp.TabIndex = 1;
            this.tbp.Text = "应收与应付统计";
            this.tbp.UseVisualStyleBackColor = true;
            // 
            // btSearch2
            // 
            this.btSearch2.Location = new System.Drawing.Point(348, 8);
            this.btSearch2.Name = "btSearch2";
            this.btSearch2.Size = new System.Drawing.Size(75, 23);
            this.btSearch2.TabIndex = 108;
            this.btSearch2.Text = "查询";
            this.btSearch2.UseVisualStyleBackColor = true;
            this.btSearch2.Click += new System.EventHandler(this.btSearch2_Click);
            // 
            // createDateTimeE2
            // 
            this.createDateTimeE2.CustomFormat = "";
            this.createDateTimeE2.Location = new System.Drawing.Point(215, 9);
            this.createDateTimeE2.Name = "createDateTimeE2";
            this.createDateTimeE2.Size = new System.Drawing.Size(116, 21);
            this.createDateTimeE2.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "查询日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(191, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 104;
            this.label5.Text = "至";
            // 
            // createDateTimeS2
            // 
            this.createDateTimeS2.CustomFormat = "";
            this.createDateTimeS2.Location = new System.Drawing.Point(69, 9);
            this.createDateTimeS2.Name = "createDateTimeS2";
            this.createDateTimeS2.Size = new System.Drawing.Size(116, 21);
            this.createDateTimeS2.TabIndex = 103;
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
            this.startTime,
            this.amountIN,
            this.amountOUT,
            this.courseNo,
            this.userNO,
            this.Uway});
            this.dgvData2.Location = new System.Drawing.Point(6, 33);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.RowHeadersVisible = false;
            this.dgvData2.RowTemplate.Height = 23;
            this.dgvData2.Size = new System.Drawing.Size(710, 397);
            this.dgvData2.TabIndex = 54;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 80;
            // 
            // amountIN
            // 
            this.amountIN.HeaderText = "应收";
            this.amountIN.Name = "amountIN";
            this.amountIN.ReadOnly = true;
            // 
            // amountOUT
            // 
            this.amountOUT.HeaderText = "应付";
            this.amountOUT.Name = "amountOUT";
            this.amountOUT.ReadOnly = true;
            // 
            // courseNo
            // 
            this.courseNo.HeaderText = "课程";
            this.courseNo.Name = "courseNo";
            this.courseNo.ReadOnly = true;
            // 
            // userNO
            // 
            this.userNO.HeaderText = "姓名";
            this.userNO.Name = "userNO";
            this.userNO.ReadOnly = true;
            // 
            // Uway
            // 
            this.Uway.HeaderText = "报名途径";
            this.Uway.Name = "Uway";
            this.Uway.ReadOnly = true;
            this.Uway.Width = 200;
            // 
            // labCashInS
            // 
            this.labCashInS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashInS.AutoSize = true;
            this.labCashInS.BackColor = System.Drawing.Color.White;
            this.labCashInS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashInS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashInS.ForeColor = System.Drawing.Color.Red;
            this.labCashInS.Location = new System.Drawing.Point(76, 445);
            this.labCashInS.Name = "labCashInS";
            this.labCashInS.Size = new System.Drawing.Size(14, 14);
            this.labCashInS.TabIndex = 118;
            this.labCashInS.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 117;
            this.label6.Text = "收入小计：";
            // 
            // labCashOutS
            // 
            this.labCashOutS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashOutS.AutoSize = true;
            this.labCashOutS.BackColor = System.Drawing.Color.White;
            this.labCashOutS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashOutS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashOutS.ForeColor = System.Drawing.Color.Red;
            this.labCashOutS.Location = new System.Drawing.Point(272, 443);
            this.labCashOutS.Name = "labCashOutS";
            this.labCashOutS.Size = new System.Drawing.Size(14, 14);
            this.labCashOutS.TabIndex = 116;
            this.labCashOutS.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(193, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 115;
            this.label9.Text = "支出小计：";
            // 
            // labCashInS2
            // 
            this.labCashInS2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashInS2.AutoSize = true;
            this.labCashInS2.BackColor = System.Drawing.Color.White;
            this.labCashInS2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashInS2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashInS2.ForeColor = System.Drawing.Color.Red;
            this.labCashInS2.Location = new System.Drawing.Point(74, 443);
            this.labCashInS2.Name = "labCashInS2";
            this.labCashInS2.Size = new System.Drawing.Size(14, 14);
            this.labCashInS2.TabIndex = 118;
            this.labCashInS2.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 117;
            this.label7.Text = "应收小计：";
            // 
            // labCashOutS2
            // 
            this.labCashOutS2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCashOutS2.AutoSize = true;
            this.labCashOutS2.BackColor = System.Drawing.Color.White;
            this.labCashOutS2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCashOutS2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCashOutS2.ForeColor = System.Drawing.Color.Red;
            this.labCashOutS2.Location = new System.Drawing.Point(270, 441);
            this.labCashOutS2.Name = "labCashOutS2";
            this.labCashOutS2.Size = new System.Drawing.Size(14, 14);
            this.labCashOutS2.TabIndex = 116;
            this.labCashOutS2.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(191, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 12);
            this.label12.TabIndex = 115;
            this.label12.Text = "应付小计：";
            // 
            // FrmIncomeQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmIncomeQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "财务统计列表";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpIncome.ResumeLayout(false);
            this.tbpIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tbp.ResumeLayout(false);
            this.tbp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btColse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpIncome;
        private System.Windows.Forms.TabPage tbp;
        private System.Windows.Forms.Label labTotalCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label labCashInB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labCashOutB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker createDateTimeE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker createDateTimeS;
        private System.Windows.Forms.DateTimePicker createDateTimeE2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker createDateTimeS2;
        private System.Windows.Forms.DataGridView dgvData2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btSearch2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountsIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountsOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn icometype;
        private System.Windows.Forms.DataGridViewTextBoxColumn imenber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uway;
        private System.Windows.Forms.Label labCashInS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCashOutS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labCashInS2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCashOutS2;
        private System.Windows.Forms.Label label12;
    }
}