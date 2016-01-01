using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicHelper;

namespace trainNewSun
{
    public partial class FrmmenberQ : Form
    {
        tblCourse cou = new tblCourse();
        B_tblCourse bcou = new B_tblCourse();
        tblmenber model = new tblmenber();
        B_tblmenber bmodel = new B_tblmenber();
        FrmMain main;
        public bool isGetRelt = false;//是否要返回值
        public string result = string.Empty;
        public List<string> unserNos=new List<string>();
        string utype = "U";
        string str_RowSelect = string.Empty;
        string strOpenStyle = ""; // 上课页面
        public List<tblmenber> itemMastSelects = new List<tblmenber>();//供选择的成员

        public FrmmenberQ(FrmMain parent,string _utype)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.utype = _utype;
            loadData();
        }

        public FrmmenberQ(bool isGet, string _utype)
        {
            InitializeComponent();
            isGetRelt = isGet;
            this.utype = _utype;
            loadData();
            setBtDisplay();
        }
       


        /*********************************/

        public void loadData()
        {
            loadCourse();
            loadDataList();
        }

        public void loadDataList()
        {
          tblmenber m=new tblmenber();
          m.Utype = utype;
          getDataList(m);
        }


        public void setBtDisplay()
        {
            if (isGetRelt == true)
            {
                btChoose.Visible = true;
                tsstorChoose.Visible = true;
                btEdit.Visible = false;
                tsstorEdit.Visible = false;
                btSignin.Visible = false;
                btDelte.Visible = false;
                tsstorDel.Visible = false;
                tsstorSignin.Visible = false;
            }
        
        }

        public void loadCourse()
        {
            
            cbxcourse.DataSource = null;
            cbxcourse.ValueMember = "courseNo";
            cbxcourse.DisplayMember = "courseName";
            cbxcourse.DataSource = bcou.GetModels(new tblCourse());
        }


        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataList(tblmenber mod)
        {
            List<tblmenber> users = new List<tblmenber>();
            users = bmodel.GetModels(mod);
            dgvData.Rows.Clear();
            if (users != null)
            {
                if (users.Count > 0)
                {
                    
                    foreach (tblmenber u in users)
                    {
                        dgvData.Rows.Add();
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value = false;
                        
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["UserNo"].Value = Convert.ToString(u.UserNo);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["ChineseName"].Value = Convert.ToString(u.ChineseName);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uschool"].Value = Convert.ToString(u.Uschool);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uclass"].Value = Convert.ToString(u.Uclass);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Umobile"].Value = Convert.ToString(u.Umobile);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uqq"].Value = Convert.ToString(u.Uqq);
                        tblCourse tc = bcou.GetFullInfo(u.Uqq);
                        if (tc != null)
                            dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uqq"].Value = Convert.ToString(tc.courseName);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Usex"].Value = Convert.ToString(u.Usex);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Valid"].Value = Convert.ToString(u.Valid);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uaddtime"].Value = Convert.ToString(u.Uaddtime);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["Uway"].Value = Convert.ToString(u.Uway);
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["colSigninTime"].Value = Convert.ToString(u.SigninTime);
                    }
                }

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FrmmenberM frm = new FrmmenberM(main,utype);
            frm.ShowDialog();
            if (frm.result == true)
            {
                tblmenber mod = new tblmenber();
                mod.Utype = utype;
                getDataList(mod);
            }
        }

        private void tbxKeyW_TextChanged(object sender, EventArgs e)
        {
            //string keyw = tbxKeyW.Text.Trim();
            //if (string.IsNullOrEmpty(keyw))
            //{
            //    tblmenber mod = new tblmenber();
            //    mod.Utype = utype;
            //    getDataList(mod);
            //}
        }

        private void tbxKeyW_KeyDown(object sender, KeyEventArgs e)
        {
            string str = tbxKeyW.Text.Trim();

            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    tblmenber mod = new tblmenber();
                    mod.UserNo = str;
                    mod.Uschool = str;
                    mod.Uclass = str;
                    mod.ChineseName = str;
                    getDataList(mod);
                }
            }

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows.Count > 0 && e.RowIndex != -1)
            {
                str_RowSelect = Convert.ToString(dgvData.Rows[e.RowIndex].Cells["UserNo"].Value);
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvData.ColumnCount; j++)
                    {
                        if (i != e.RowIndex)
                        {
                            dgvData.Rows[i].Cells[j].Style.BackColor =Color.White;
                        }
                        else
                            dgvData.Rows[e.RowIndex].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
           
        }

        public void Edit()
        {
            if (string.IsNullOrEmpty(str_RowSelect))
            {
                MessageBox.Show("请先点击成员列表中其中一条数据后再操作!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            FrmmenberM frm = new FrmmenberM(str_RowSelect,utype);
            frm.ShowDialog();
            if (frm.result == true)
                loadData();
        }

        private void cbxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheckAll.Checked == true)
            {
                func_CheckAll(true);
                cbxCheckAll.Text = "全消";
            }
            else
            {
                func_CheckAll(false);
                cbxCheckAll.Text = "全选";
            }
        }

        public void func_CheckAll(bool chek)
        {
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                dgvData.Rows[i].Cells[0].Value = chek;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            unserNos.Clear();
            if (dgvData.Rows.Count > 0)
            {
                if (isGetRelt == true)
                {
                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        if ((bool)dgvData.Rows[i].Cells[0].Value == true)
                            unserNos.Add("'" + dgvData.Rows[i].Cells["UserNo"].Value + "'");
                    }
                    this.Hide();
                    return;
                }
            }
        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvData.CurrentCell != null)
            {
                if (e.ColumnIndex == 0)
                {
                    if ((bool)dgvData.Rows[e.RowIndex].Cells[0].Value == false)
                        dgvData.Rows[e.RowIndex].Cells[0].Value = true;
                    else
                        dgvData.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((utype == "U" || utype == "H") && isGetRelt == true)
            {
                unserNos.Clear();
                unserNos.Add("'" + dgvData.Rows[e.RowIndex].Cells["UserNo"].Value + "'"); 
                this.Hide();
                return;
            }
            else if (isGetRelt == true)
            {
                result = str_RowSelect;
                this.Hide();
                return;
            }
            Edit();
        }

        private void cbxcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataList(new tblmenber { Uqq = Convert.ToString(cbxcourse.SelectedValue), Utype = utype });
        }

        private void btSignin_Click(object sender, EventArgs e)
        {
            string strUserNo = str_RowSelect;
            if (string.IsNullOrWhiteSpace(strUserNo))
            {
                MessageBox.Show("请先点击相应学员后再签到！");
                return;
            }

            if (MessageBox.Show("确定要签到吗？", "签到确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string nowTime = DateTime.Now.Date.ToString("yyyy-MM-dd") + "日" + DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes + ":" + DateTime.Now.TimeOfDay.Seconds;
                string nowTime2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (bmodel.UpdateS_Signin(strUserNo, nowTime2))
                {

                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        if (dgvData.Rows[i].Cells["UserNo"].Value.ToString() == strUserNo)
                        {
                            dgvData.Rows[i].Cells["colSigninTime"].Value = nowTime2;
                            break;
                        }
                    }

                    List<string> listPhones = new List<string>();
                    tblmenber per = bmodel.GetFullInfo(strUserNo);
                    listPhones.Add(per.Umobile);
                    if (RexHelper.IsMatch(Convert.ToString(per.Umobile).Trim(), RexHelper.rexType.Phone))
                    {
                        new System.Threading.Tasks.TaskFactory().StartNew(() =>
                        {
                            new B_SMS().ToMobile(new SMS_msg { content = "尊敬的家长，您好，您的孩子" + per.ChineseName + "已于 " + nowTime + " 到达新太阳。", phones = listPhones });
                        }).ContinueWith(t => MessageBox.Show("签到成功！信息已发送！"));
                    }
                    else
                    {
                        MessageBox.Show("签到成功！由于手机号码不符合要求，信息未发送！");
                    }

                }
                else
                {
                    MessageBox.Show("签到失败！");
                }
            }
        }

        private void btDelte_Click(object sender, EventArgs e)
        {
            List<string> persons = new List<string>();
            if (dgvData.Rows.Count > 0)
            {
                for (int i = 0; i < dgvData.Rows.Count; ++i)
                {
                    if ((bool)dgvData.Rows[i].Cells[0].Value == true)
                    {
                        persons.Add(Convert.ToString(dgvData.Rows[i].Cells["UserNo"].Value));
                    }
                }
            }
            if (persons.Count == 0)
            {
                MessageBox.Show("请先选择要删除的学员！");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "删除确认", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            if (bmodel.DelModels(persons))
            {
                MessageBox.Show("删除成功！");
                for (int i = 0; i < dgvData.Rows.Count; ++i)
                {
                    if (persons.Contains(Convert.ToString(dgvData.Rows[i].Cells["UserNo"].Value)))
                        dgvData.Rows[i].Visible = false;
                }
                
            }
            else
                MessageBox.Show("删除失败！");
        }

       
    }

        
}
