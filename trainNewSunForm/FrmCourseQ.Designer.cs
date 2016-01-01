namespace trainNewSun
{
    partial class FrmCourseQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseQ));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btItemAdd = new System.Windows.Forms.ToolStripButton();
            this.tsstorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btDelte = new System.Windows.Forms.ToolStripButton();
            this.tsstorChoose = new System.Windows.Forms.ToolStripSeparator();
            this.btChoose = new System.Windows.Forms.ToolStripButton();
            this.tsstorClose = new System.Windows.Forms.ToolStripSeparator();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvwData = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btItemAdd,
            this.tsstorEdit,
            this.btEdit,
            this.toolStripSeparator3,
            this.btDelte,
            this.tsstorChoose,
            this.btChoose,
            this.tsstorClose,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(300, 67);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btItemAdd
            // 
            this.btItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btItemAdd.Image")));
            this.btItemAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btItemAdd.Name = "btItemAdd";
            this.btItemAdd.Size = new System.Drawing.Size(52, 64);
            this.btItemAdd.Text = "增加";
            this.btItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btItemAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            this.toolStripSeparator3.Visible = false;
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
            this.btDelte.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "(回车键搜索)";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(61, 70);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(152, 21);
            this.tbx_Name.TabIndex = 12;
            this.tbx_Name.TextChanged += new System.EventHandler(this.tbx_Name_TextChanged);
            this.tbx_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Name_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "课程名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvwData);
            this.groupBox1.Location = new System.Drawing.Point(3, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 403);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程列表";
            // 
            // tvwData
            // 
            this.tvwData.Location = new System.Drawing.Point(7, 15);
            this.tvwData.Name = "tvwData";
            this.tvwData.Size = new System.Drawing.Size(276, 383);
            this.tvwData.TabIndex = 0;
            this.tvwData.DoubleClick += new System.EventHandler(this.tvwData_DoubleClick);
            // 
            // FrmCourseQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(300, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmCourseQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程维护";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btItemAdd;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btDelte;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvwData;
        private System.Windows.Forms.ToolStripButton btChoose;
        private System.Windows.Forms.ToolStripSeparator tsstorEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator tsstorChoose;
        private System.Windows.Forms.ToolStripSeparator tsstorClose;
    }
}