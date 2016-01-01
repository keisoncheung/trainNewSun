namespace trainNewSun
{
    partial class FrmIncomeM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncomeM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btColse = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTeah = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxamounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateAddDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxBrandName = new System.Windows.Forms.TextBox();
            this.cbxistype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.toolStripSeparator2,
            this.btSave,
            this.toolStripSeparator1,
            this.btColse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 67);
            this.toolStrip1.TabIndex = 8;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
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
            this.btColse.Click += new System.EventHandler(this.btClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTeah);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxamounts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateAddDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxBrandName);
            this.groupBox1.Controls.Add(this.cbxistype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "财务记账信息编辑";
            // 
            // cbxTeah
            // 
            this.cbxTeah.BackColor = System.Drawing.Color.White;
            this.cbxTeah.FormattingEnabled = true;
            this.cbxTeah.Location = new System.Drawing.Point(292, 45);
            this.cbxTeah.Name = "cbxTeah";
            this.cbxTeah.Size = new System.Drawing.Size(147, 20);
            this.cbxTeah.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "生意伙伴";
            // 
            // tbxamounts
            // 
            this.tbxamounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxamounts.Location = new System.Drawing.Point(71, 71);
            this.tbxamounts.Name = "tbxamounts";
            this.tbxamounts.Size = new System.Drawing.Size(147, 21);
            this.tbxamounts.TabIndex = 42;
            this.tbxamounts.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "金    额";
            // 
            // dateAddDate
            // 
            this.dateAddDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateAddDate.Location = new System.Drawing.Point(291, 71);
            this.dateAddDate.Name = "dateAddDate";
            this.dateAddDate.Size = new System.Drawing.Size(147, 21);
            this.dateAddDate.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "记账时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "类    别";
            // 
            // tbxBrandName
            // 
            this.tbxBrandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBrandName.Location = new System.Drawing.Point(71, 20);
            this.tbxBrandName.Name = "tbxBrandName";
            this.tbxBrandName.Size = new System.Drawing.Size(369, 21);
            this.tbxBrandName.TabIndex = 15;
            // 
            // cbxistype
            // 
            this.cbxistype.FormattingEnabled = true;
            this.cbxistype.Location = new System.Drawing.Point(71, 45);
            this.cbxistype.Name = "cbxistype";
            this.cbxistype.Size = new System.Drawing.Size(147, 20);
            this.cbxistype.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "记账名称";
            // 
            // FrmIncomeM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 178);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmIncomeM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btColse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxistype;
        private System.Windows.Forms.DateTimePicker dateAddDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxamounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTeah;
        private System.Windows.Forms.Label label2;
    }
}