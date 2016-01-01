namespace trainNewSun
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuAdminM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuTrainee = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuParner = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuHaveClass = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudHC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTeacHC = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFinancial = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuCashIn = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuCashOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.smsSends = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuSMSsend = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.MainMenuPerson,
            this.MainMenuHaveClass,
            this.MainMenuFinancial,
            this.smsSends,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1822, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuAdminM,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(106, 36);
            this.fileMenu.Text = "文件(&F)";
            // 
            // MainMenuAdminM
            // 
            this.MainMenuAdminM.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuAdminM.Image")));
            this.MainMenuAdminM.ImageTransparentColor = System.Drawing.Color.Black;
            this.MainMenuAdminM.Name = "MainMenuAdminM";
            this.MainMenuAdminM.ShowShortcutKeys = false;
            this.MainMenuAdminM.Size = new System.Drawing.Size(200, 36);
            this.MainMenuAdminM.Text = "管理员管理";
            this.MainMenuAdminM.Click += new System.EventHandler(this.MainMenuAdminM_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.exitToolStripMenuItem.Text = "退出(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // MainMenuPerson
            // 
            this.MainMenuPerson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuTrainee,
            this.MainMenuTeacher,
            this.MainMenuParner,
            this.MenuItemCourse,
            this.MainMenuOthers});
            this.MainMenuPerson.Name = "MainMenuPerson";
            this.MainMenuPerson.Size = new System.Drawing.Size(177, 36);
            this.MainMenuPerson.Text = "基本资料管理";
            // 
            // MainMenuTrainee
            // 
            this.MainMenuTrainee.Name = "MainMenuTrainee";
            this.MainMenuTrainee.Size = new System.Drawing.Size(240, 36);
            this.MainMenuTrainee.Text = "学员资料管理";
            this.MainMenuTrainee.Click += new System.EventHandler(this.MainMenuTrainee_Click);
            // 
            // MainMenuTeacher
            // 
            this.MainMenuTeacher.Name = "MainMenuTeacher";
            this.MainMenuTeacher.Size = new System.Drawing.Size(240, 36);
            this.MainMenuTeacher.Text = "教师资料管理";
            this.MainMenuTeacher.Click += new System.EventHandler(this.MainMenuTeacher_Click);
            // 
            // MainMenuParner
            // 
            this.MainMenuParner.Name = "MainMenuParner";
            this.MainMenuParner.Size = new System.Drawing.Size(240, 36);
            this.MainMenuParner.Text = "生意伙伴管理";
            this.MainMenuParner.Click += new System.EventHandler(this.MainMenuParner_Click);
            // 
            // MenuItemCourse
            // 
            this.MenuItemCourse.Name = "MenuItemCourse";
            this.MenuItemCourse.Size = new System.Drawing.Size(240, 36);
            this.MenuItemCourse.Text = "课程资料管理";
            this.MenuItemCourse.Click += new System.EventHandler(this.MenuItemCourse_Click);
            // 
            // MainMenuOthers
            // 
            this.MainMenuOthers.Name = "MainMenuOthers";
            this.MainMenuOthers.Size = new System.Drawing.Size(240, 36);
            this.MainMenuOthers.Text = "其他人员管理";
            this.MainMenuOthers.Click += new System.EventHandler(this.MainMenuOthers_Click);
            // 
            // MainMenuHaveClass
            // 
            this.MainMenuHaveClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudHC,
            this.MenuItemTeacHC});
            this.MainMenuHaveClass.Name = "MainMenuHaveClass";
            this.MainMenuHaveClass.Size = new System.Drawing.Size(127, 36);
            this.MainMenuHaveClass.Text = "上课管理";
            // 
            // MenuItemStudHC
            // 
            this.MenuItemStudHC.Name = "MenuItemStudHC";
            this.MenuItemStudHC.Size = new System.Drawing.Size(240, 36);
            this.MenuItemStudHC.Text = "学生上课登记";
            this.MenuItemStudHC.Click += new System.EventHandler(this.MenuItemStudHC_Click);
            // 
            // MenuItemTeacHC
            // 
            this.MenuItemTeacHC.Name = "MenuItemTeacHC";
            this.MenuItemTeacHC.Size = new System.Drawing.Size(240, 36);
            this.MenuItemTeacHC.Text = "教师上课登记";
            this.MenuItemTeacHC.Click += new System.EventHandler(this.MenuItemTeacHC_Click);
            // 
            // MainMenuFinancial
            // 
            this.MainMenuFinancial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuCashIn,
            this.MainMenuCashOut,
            this.MainMenuFinance});
            this.MainMenuFinancial.Name = "MainMenuFinancial";
            this.MainMenuFinancial.Size = new System.Drawing.Size(127, 36);
            this.MainMenuFinancial.Text = "财务管理";
            // 
            // MainMenuCashIn
            // 
            this.MainMenuCashIn.Name = "MainMenuCashIn";
            this.MainMenuCashIn.Size = new System.Drawing.Size(190, 36);
            this.MainMenuCashIn.Text = "收入记账";
            this.MainMenuCashIn.Click += new System.EventHandler(this.MainMenuCashIn_Click);
            // 
            // MainMenuCashOut
            // 
            this.MainMenuCashOut.Name = "MainMenuCashOut";
            this.MainMenuCashOut.Size = new System.Drawing.Size(190, 36);
            this.MainMenuCashOut.Text = "支出记账";
            this.MainMenuCashOut.Click += new System.EventHandler(this.MainMenuCashOut_Click);
            // 
            // MainMenuFinance
            // 
            this.MainMenuFinance.Name = "MainMenuFinance";
            this.MainMenuFinance.Size = new System.Drawing.Size(190, 36);
            this.MainMenuFinance.Text = "财务统计";
            this.MainMenuFinance.Click += new System.EventHandler(this.MainMenuFinance_Click);
            // 
            // smsSends
            // 
            this.smsSends.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuSMSsend});
            this.smsSends.Name = "smsSends";
            this.smsSends.Size = new System.Drawing.Size(127, 36);
            this.smsSends.Text = "短信平台";
            // 
            // MainMenuSMSsend
            // 
            this.MainMenuSMSsend.Name = "MainMenuSMSsend";
            this.MainMenuSMSsend.Size = new System.Drawing.Size(190, 36);
            this.MainMenuSMSsend.Text = "发送短信";
            this.MainMenuSMSsend.Click += new System.EventHandler(this.MainMenuSMSsend_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(118, 36);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.MainMenuAboutUs});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(112, 36);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(262, 6);
            // 
            // MainMenuAboutUs
            // 
            this.MainMenuAboutUs.Name = "MainMenuAboutUs";
            this.MainMenuAboutUs.Size = new System.Drawing.Size(265, 36);
            this.MainMenuAboutUs.Text = "关于软件与作者";
            this.MainMenuAboutUs.Click += new System.EventHandler(this.MainMenuAboutUs_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 963);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(1822, 37);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(65, 32);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1000);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MainMenuAboutUs;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuAdminM;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuPerson;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTrainee;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTeacher;
        private System.Windows.Forms.ToolStripMenuItem MainMenuHaveClass;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudHC;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTeacHC;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFinancial;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFinance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourse;
        private System.Windows.Forms.ToolStripMenuItem MainMenuParner;
        private System.Windows.Forms.ToolStripMenuItem MainMenuCashIn;
        private System.Windows.Forms.ToolStripMenuItem MainMenuCashOut;
        private System.Windows.Forms.ToolStripMenuItem smsSends;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSMSsend;
        private System.Windows.Forms.ToolStripMenuItem MainMenuOthers;
    }
}



