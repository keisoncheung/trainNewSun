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
    public partial class FrmmenberM : Form
    {
        tblCourse cou = new tblCourse();
        B_tblCourse bcou = new B_tblCourse();
        tblmenber model = new tblmenber();
        B_tblmenber bmodel = new B_tblmenber();
        FrmMain main;
        public string strItemNO = "";
        public bool result = false;
        string utype = "0";

        public FrmmenberM(FrmMain parent, string stype)
        {
            InitializeComponent();
            this.MdiParent = parent;
            utype = stype;
            loadData();
        }


        public FrmmenberM(string uno, string stype)
        {
            InitializeComponent();
            utype = stype;
            strItemNO = uno;
            loadData();
        }


        /*********************************/

        public void loadData()
        {
            getData();
        }

        public void getData()
        {

            get_Course();
            getDataList();

        }

        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataList()
        {

            if (utype == "H")
            {
                tbxclass.Visible = false;
                cbxUway.Visible = false;
                cbxCourse.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
            }
            tblmenber u = new tblmenber();
            u = bmodel.GetFullInfo(strItemNO);
            if (u != null)
            {
                labUserNo.Text = u.UserNo;
                tbxChineseName.Text = u.ChineseName;
                tbxclass.Text = u.Uclass;
                tbxMobile.Text = u.Umobile;
                cbxCourse.SelectedValue = u.Uqq;
                cbxsch.Text = u.Uschool;
                cbxSex.Text = u.Usex;
                dateAddDate.Text = Convert.ToString(u.Uaddtime);
                cbxUway.Text = u.Uway;
                cbxValid.Text = "启用中";
                if (u.Valid == "N")
                    cbxValid.Text = "失效中";
            }
            else
            {
                labUserNo.Text = bmodel.GetMaxNo(utype);
                cbxValid.Text = "启用中";

            }
        }


        public void get_Course()
        {
            List<tblCourse> listData = new List<tblCourse>();
            List<tblCourse> listData2 = new List<tblCourse>();
            listData = bcou.GetModels(new tblCourse());
            if (listData.Count > 0)
            {
                foreach (tblCourse v_data in listData)
                {
                    tblCourse data = new tblCourse();
                    data.courseNo = Convert.ToString(v_data.courseNo);
                    data.courseName = Convert.ToString(v_data.courseName);
                    listData2.Add(data);
                }
            }
            cbxCourse.DataSource = null;
            cbxCourse.DataSource = listData2;
            cbxCourse.DisplayMember = "courseName";
            cbxCourse.ValueMember = "courseNo";
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        public void add()
        {
            tblmenber u = new tblmenber();
            labUserNo.Text = bmodel.GetMaxNo(utype);
            tbxChineseName.Text = string.Empty;
            tbxclass.Text = string.Empty;
            tbxMobile.Text = string.Empty;
            cbxsch.Text = string.Empty;
            cbxCourse.Text = string.Empty;
            cbxSex.Text = "男";
            cbxValid.Text = "启用中";
            dateAddDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            save();
        }

        public void save()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string strUno = labUserNo.Text;
            string strValid = Convert.ToString(cbxValid.Text);
            string strsch = Convert.ToString(cbxsch.Text);
            string strclass = tbxclass.Text.Trim();
            string strmobile = tbxMobile.Text.Trim();
            string strqq = Convert.ToString(cbxCourse.Text);
            string strChineseName = tbxChineseName.Text.Trim();
            string strsex = cbxSex.Text;
            string strway = cbxUway.Text;
            string strAddDate = dateAddDate.Text;
            tblmenber mod = new tblmenber();
            if (string.IsNullOrEmpty(strChineseName))
            {
                MessageBox.Show("成员姓名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(strValid))
            {
                MessageBox.Show("成员状态不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (utype != "H")
            {
                if (string.IsNullOrEmpty(strqq))
                {
                    MessageBox.Show("课程不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (string.IsNullOrEmpty(strsch))
            {
                MessageBox.Show("学校不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (string.IsNullOrEmpty(strsex))
            {
                MessageBox.Show("性别不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mod.UserNo = strUno;
            mod.ChineseName = strChineseName;
            mod.Uschool = strsch;
            mod.Usex = strsex;
            mod.Uway = strway;
            mod.Utype = utype;
            mod.Umobile = strmobile;
            mod.Uqq = Convert.ToString(cbxCourse.SelectedValue);
            mod.Uclass = strclass;
            mod.Uaddtime = strAddDate;
            mod.S_flag = "N";

            if (strValid == "启用中")
                mod.Valid = "Y";
            else
                mod.Valid = "N";

            StringBuilder sbr_Msg = new StringBuilder();
            if (bmodel.isExistModel(strUno) == true)
            {
                tblmenber U = new tblmenber();

                U = bmodel.GetFullInfo(strUno);

                if (U != null)
                {
                    if (U.UserNo != strUno)
                    {
                        MessageBox.Show("该用户已存在，不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxChineseName.Focus();
                        return;
                    }
                    mod.S_flag = U.S_flag;
                    if (bmodel.UpdateModel(mod))
                    {
                        SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", strUno + "更新成功！");
                        result = true;
                        sbr_Msg.Append("资料更新成功！");

                        //if (DateTime.Now.Hour < 9 || Convert.ToDouble(DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString()) > 17.30)
                        //    sbr_Msg.Append("但未发短信，发送短信请在白天9：00——17:30之间再发送！");
                        //else
                        //{
                            bmodel.SendSMSforM(Convert.ToString(mod.Umobile));
                            if (mod.S_flag == "N")
                                bmodel.UpdateS_FLAG(mod.UserNo);
                            sbr_Msg.Append("并且短信已成功发送！");

                        //}

                        MessageBox.Show(sbr_Msg.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", strUno + "更新失败！");
                        result = false;
                        sbr_Msg.Length = 0;
                        sbr_Msg.Append("更新失败！");
                        MessageBox.Show(sbr_Msg.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (bmodel.InsertModel(mod) == true)
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", strUno + "添加成功！");
                    result = true;
                    //if (DateTime.Now.Hour < 9 || Convert.ToDouble(DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString()) > 17.30)
                    //    sbr_Msg.Append("但未发短信，发送短信请在白天9：00——17:30之间再发送！");
                    //else
                    //{
                        bmodel.SendSMSforM(Convert.ToString(model.Umobile));
                        if (mod.S_flag == "N")
                            bmodel.UpdateS_FLAG(mod.UserNo);
                        sbr_Msg.Append("短信已成功发送！");

                    //}
                    MessageBox.Show(sbr_Msg.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", strUno + "添加失败！");
                    result = false;
                    sbr_Msg.Length = 0;
                    sbr_Msg.Append("添加失败！");
                    MessageBox.Show(sbr_Msg.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btDele_Click(object sender, EventArgs e)
        {

        }

    }
}
