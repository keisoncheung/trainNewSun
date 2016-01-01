using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace trainNewSun.SystemConfig
{
    public partial class FrmAdminM : Form
    {
        tblAdmin model = new tblAdmin();
        B_tblAdmin bmodel = new B_tblAdmin();
        FrmMain main;
        bool result = false; 
        public FrmAdminM(FrmMain parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            loadData();
        }

        /*********************************/

        public void loadData()
        {
            getData();
        }

        public void getData()
        {
            getDataList();
        }

        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataList()
        {
            tblAdmin u = new tblAdmin();
            u = bmodel.GetFullInfo(SystemInfo.LoginUser);
            if (u != null)
            {
                labUserNo.Text = u.UserNo;
                tbxLoginName.Text = u.LoginName;
                tbxLoginName.Enabled = false;
                tbxChineseName.Text = u.ChineseName;
                tbxA_money.Text = u.A_money;
                cbxValid.Text = "启用中";
                tbxsmsContent.Text = u.smsContent;
                labSMS.Text = Convert.ToString(u.smsNums);
                if (u.Valid == "N")
                    cbxValid.Text = "失效中";
                //tbxAcountpwd.Text = u.Acountpwd;
            }
            else
            {
                labUserNo.Text = bmodel.GetMaxNo();
                cbxValid.Text = "启用中";
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            save();
        }


        public void save()
        {
            string strUno = labUserNo.Text;
            string strValid = Convert.ToString(cbxValid.Text);
            string strA_money = Convert.ToString(tbxA_money.Text);
            string strLoginName = tbxLoginName.Text.Trim();
            string strChineseName = tbxChineseName.Text.Trim();
            string strPwd = tbxPassword.Text.Trim();
            string strPwd2 = tbxPassword2.Text.Trim();
            string strAcountPwd = tbxAcountpwd.Text.Trim();
            tblAdmin mod = new tblAdmin();
            if (string.IsNullOrEmpty(strLoginName))
            {
                MessageBox.Show("用户登录名不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strValid))
            {
                MessageBox.Show("账户状态不能为空！");
                return;
            }


            if (string.IsNullOrEmpty(strA_money))
            {
                MessageBox.Show("原始余额不能为空！");
                return;
            }



            if (strPwd != strPwd2)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
                return;
            }


            mod.UserNo = strUno;
            mod.LoginName = strLoginName;
            mod.ChineseName = strChineseName;
            mod.A_money = strA_money;
            mod.smsContent = tbxsmsContent.Text.Trim();
            

            if (strValid == "启用中")
                mod.Valid = "Y";
            else
                mod.Valid = "N";




            if (bmodel.isExistModel(strLoginName) == true)
            {
                tblAdmin U = new tblAdmin();
                U = bmodel.GetFullInfo(strLoginName);
                if (U != null)
                {
                    if (string.IsNullOrEmpty(strPwd))
                    {
                        if (MessageBox.Show("密码置空的话将不会修改原密码，是否继续保存？", "删除", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                    }
                    else
                    {
                        mod.Password = SystemInfo.MD5(strPwd);
                    }

                    if(!string.IsNullOrEmpty(strAcountPwd))
                        mod.Acountpwd = strAcountPwd;

                    if (U.UserNo != strUno)
                    {
                        MessageBox.Show("该用户已存在，不能重复添加！");
                        tbxLoginName.Focus();
                        return;
                    }

                    if (bmodel.UpdateModel(mod))
                    {
                        SystemInfo.Log(SystemInfo.MsgType.Type.ADM + "", strUno + "更新成功！");
                        result = true;
                        MessageBox.Show("更新成功！");
                    }
                    else
                    {
                        SystemInfo.Log(SystemInfo.MsgType.Type.ADM + "", strUno + "更新失败！");
                        result = false;
                        MessageBox.Show("更新失败！");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strPwd))
                {
                    MessageBox.Show("密码不能为空！");
                    tbxPassword.Focus();
                    return;
                }
                mod.Password = SystemInfo.MD5(strPwd);
                if (bmodel.InsertModel(mod) == true)
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.ADM + "", strUno + "添加成功！");
                    result = true;
                    tbxLoginName.Enabled = false;
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.ADM + "", strUno + "添加失败！");
                    result = false;
                    MessageBox.Show("添加失败！");
                }
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
