namespace trainNewSun
{
    partial class FrmCourseM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btColse = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxBrandName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBrandNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStrip1.Size = new System.Drawing.Size(337, 67);
            this.toolStrip1.TabIndex = 7;
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
            this.groupBox1.Controls.Add(this.tbxBrandName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxBrandNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息";
            // 
            // tbxBrandName
            // 
            this.tbxBrandName.Location = new System.Drawing.Point(67, 49);
            this.tbxBrandName.Name = "tbxBrandName";
            this.tbxBrandName.Size = new System.Drawing.Size(257, 21);
            this.tbxBrandName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "课程编号";
            // 
            // tbxBrandNo
            // 
            this.tbxBrandNo.Enabled = false;
            this.tbxBrandNo.Location = new System.Drawing.Point(67, 19);
            this.tbxBrandNo.Name = "tbxBrandNo";
            this.tbxBrandNo.Size = new System.Drawing.Size(257, 21);
            this.tbxBrandNo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "课程名称";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            // 
            // FrmCourseM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmCourseM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程编辑";
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
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btColse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxBrandName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBrandNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}