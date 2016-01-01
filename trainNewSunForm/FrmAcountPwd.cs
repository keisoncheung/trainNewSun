using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trainNewSun
{
    public partial class FrmAcountPwd : Form
    {
        B_tblIncome btin = new B_tblIncome();
        public bool result = false;
        public FrmAcountPwd()
        {
            InitializeComponent();
            tbxPwd.Focus();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            EnterIn();
        }

        private void tbxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterIn();
        }

        private void EnterIn()
        {
            string strPwd = tbxPwd.Text.Trim();
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("请输入密码！");
                tbxPwd.Focus();
                return;
            }
            if (btin.ifContinue(SystemInfo.LoginUser, strPwd))
            {
                result = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误，请重新输入！");
                tbxPwd.Text = string.Empty;
                tbxPwd.Focus();
                return;
            }
        }

        private void FrmAcountPwd_Activated(object sender, EventArgs e)
        {
            this.tbxPwd.Focus();
        }
   
    }
}
