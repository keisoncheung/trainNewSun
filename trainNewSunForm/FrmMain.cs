using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using trainNewSun.SystemConfig;

namespace trainNewSun
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
            this.Text = "新太阳教育培训机构管理系统 "+SystemInfo.Version;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainMenuTrainee_Click(object sender, EventArgs e)
        {
            FrmmenberQ frm = new FrmmenberQ(this, "U");
            frm.Text = "学员管理";
            frm.Show();
        }

        private void MainMenuAdminM_Click(object sender, EventArgs e)
        {
            FrmAdminM frm = new FrmAdminM(this);
            frm.Show();
        }

        private void MainMenuTeacher_Click(object sender, EventArgs e)
        {
            FrmmenberQ frm = new FrmmenberQ(this, "T");
            frm.Text = "教师管理";
            frm.Show();
        }

        private void MenuItemStudHC_Click(object sender, EventArgs e)
        {
            FrmTrainee frm = new FrmTrainee(this);
            frm.Text = "学员上课登记";
            frm.Show();
        }

        private void MenuItemTeacHC_Click(object sender, EventArgs e)
        {
            FrmTeacher frm = new FrmTeacher(this);
            frm.Text = "教师上课登记";
            frm.Show();
        }

        private void MainMenuFinance_Click(object sender, EventArgs e)
        {
            FrmAcountPwd frmA = new FrmAcountPwd();
            frmA.ShowDialog();
            if (frmA.result == true)
            {
                FrmIncomeQ frm = new FrmIncomeQ(this);
                frm.Show();
            }
        }

        private void MenuItemCourse_Click(object sender, EventArgs e)
        {
            FrmCourseQ frm = new FrmCourseQ(this);
            frm.Text = "课程管理";
            frm.Show();
        }

        private void MenuInCome_Click(object sender, EventArgs e)
        {
            FrmIncomeM frm = new FrmIncomeM(this);
            frm.Text = "财务类别管理";
            frm.Show();
            
        }

        private void MainMenuParner_Click(object sender, EventArgs e)
        {
            FrmmenberQ frm = new FrmmenberQ(this, "P");
            frm.Text = "生意伙伴管理";
            frm.Show();
        }

        private void MainMenuCashIn_Click(object sender, EventArgs e)
        {
            FrmAcountPwd frmA = new FrmAcountPwd();
            frmA.ShowDialog();
            if (frmA.result == true)
            {
                FrmIncomeM frm = new FrmIncomeM(this, "I");
                frm.Show();
            }
            
        }

        private void MainMenuCashOut_Click(object sender, EventArgs e)
        {
             FrmAcountPwd frmA = new FrmAcountPwd();
            frmA.ShowDialog();
            if (frmA.result == true)
            {
                FrmIncomeM frm = new FrmIncomeM(this, "O");
                frm.Show();
            }
        }

        private void MainMenuAboutUs_Click(object sender, EventArgs e)
        {
            FrmAboutUs frm = new FrmAboutUs();
            frm.ShowDialog();
        }

        private void MainMenuSMSsend_Click(object sender, EventArgs e)
        {
            FrmSMS frm = new FrmSMS(this);
            frm.Show();
        }

        private void MainMenuOthers_Click(object sender, EventArgs e)
        {
            FrmmenberQ frm = new FrmmenberQ(this, "H");
            frm.Text = "其他人员管理";
            frm.Show();
        }
    }
}
