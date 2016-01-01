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
    public partial class FrmLogin : Form
    {
        B_tblAdmin bAdmin = new B_tblAdmin();
        public bool Result = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            string strname = tbxUid.Text.Trim();
            string strpwd = tbxPwd.Text.Trim();
            if (string.IsNullOrWhiteSpace(strname))
            {
                MessageBox.Show("请输入用户名!", "提示");
                return;
            }
            if (string.IsNullOrWhiteSpace(strpwd))
            {
                MessageBox.Show("请输入密码!", "提示");
                return;
            }

            if (bAdmin.isExistModel(strname))
            {
                tblAdmin TA = new tblAdmin();
                TA = bAdmin.GetFullInfo(strname);
                if (TA != null)
                {
                    if (TA.Password != SystemInfo.MD5(strpwd))
                    {
                        MessageBox.Show("密码不正确，请重新输入!","提示");
                        tbxPwd.Focus();
                        return;
                    }
                    Result = true;
                    SystemInfo.LoginUser = strname;
                    SystemInfo.SMSNums = TA.smsNums;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("不存在该用户，请重新检查后再试!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tbxUid.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("不存在该用户，请重新检查后再试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxUid.Focus();
                return;
            }
        }

        private void tbxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }


    }
}
