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
    public partial class FrmTrainee : Form
    {
        tblCourse cou = new tblCourse();
        B_tblCourse bcou = new B_tblCourse();
        tblmenber men = new tblmenber();
        B_tblmenber bmen = new B_tblmenber();
        tblHaveClass_Header hch = new tblHaveClass_Header();
        tblHaveClass_Detail hcd = new tblHaveClass_Detail();
        tblPayMoney pm = new tblPayMoney();
        B_tblHaveClass bhch = new B_tblHaveClass();
        string strMemNO = string.Empty;


        Form main;
        public bool result = false;
        public string strItemNO = "";
        public FrmTrainee(FrmMain frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;
            loadData();
        }



      


        public void loadData()
        {
            get_Course();
            get_menber();
        }

        public void getData()
        {
            string cour = Convert.ToString(cbxCourse.SelectedValue);
            string men = Convert.ToString(strMemNO);
            decimal payMoney = 0;
            dgvData.Rows.Clear();
            tblHaveClass_Header hea = new tblHaveClass_Header();
            hea = bhch.GetFullInfo(men, cour);

            if (hea != null)
            {
                payMoney = bhch.getPayMoney(cour, men);
                labPayMeny.Text = (payMoney == 0) ? "0" : Convert.ToString(payMoney);

                if (hea.HaveClass_Detail != null && hea.HaveClass_Detail.Count > 0)
                {
                    foreach (tblHaveClass_Detail det in hea.HaveClass_Detail)
                    {
                        dgvData.Rows.Add();
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value = false;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["classNum"].Value = dgvData.Rows.Count;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["startTime"].Value = det.startTime;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["amount"].Value = det.amount;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["isFinish"].Value = det.isFinish;
                        if (det.isFinish == "Y")
                            dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value = true;
                    }
                }
                //dgvData.Sort(dgvData.Columns["startTime"], ListSortDirection.Descending);
                //setTotalQty();
            }

        }

        public void setTotalQty()
        {
            int persons = 0;
            decimal AmountTotal = 0;
            decimal _labpaymoney = 0;
            for (int i = 0; i < dgvData.Rows.Count; ++i)
            {
                if (Convert.ToString(dgvData.Rows[i].Cells["isfinish"].Value) == "N")
                {
                    AmountTotal += Convert.ToDecimal(Convert.ToString(dgvData.Rows[i].Cells["amount"].Value));
                }
                if ((bool)dgvData.Rows[i].Cells[0].Value == true && Convert.ToString(dgvData.Rows[i].Cells["isfinish"].Value) == "N")
                {
                    _labpaymoney += Convert.ToDecimal(Convert.ToString(dgvData.Rows[i].Cells["amount"].Value));
                }
            }
            labClassNums.Text = Convert.ToString(dgvData.Rows.Count);
            labAmountTotal.Text = Convert.ToString(Math.Round(AmountTotal, 2));
            tbxPayMonent.Text = Convert.ToString(Math.Round(_labpaymoney, 2));
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

        public void get_menber()
        {
            //List<tblmenber> listData = new List<tblmenber>();
            //List<tblmenber> listData2 = new List<tblmenber>();
            //tblmenber _m = new tblmenber();
            //_m.Utype = "U";
            //listData = bmen.GetModels(_m);
            //if (listData.Count > 0)
            //{
            //    foreach (tblmenber v_data in listData)
            //    {
            //        tblmenber data = new tblmenber();
            //        data.UserNo = Convert.ToString(v_data.UserNo);
            //        data.ChineseName = Convert.ToString(v_data.ChineseName);
            //        listData2.Add(data);
            //    }
            //}
            //cbxTeah.DataSource = null;
            //cbxTeah.DataSource = listData2;
            //cbxTeah.DisplayMember = "ChineseName";
            //cbxTeah.ValueMember = "UserNo";

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
        }

        private void btCollections_Click(object sender, EventArgs e)
        {
            if (btSave.Enabled == true)
            {
                save("");
                btSave.Enabled = false;
            }
            string money = tbxPayMonent.Text.Trim();

            if (string.IsNullOrWhiteSpace(money) || money == "0")
            {
                MessageBox.Show("对不起，本次收款金额填写处为零，暂时不能收款！");
                return;
            }
            if (Convert.ToDecimal(money) > Convert.ToDecimal(labAmountTotal.Text.Trim()))
            {
                MessageBox.Show("对不起，本次收款金额填写不能大于应收总额，请重新修改收款金额！");
                tbxPayMonent.Focus();
                return;
            }

            string cour = Convert.ToString(cbxCourse.SelectedValue);
            string men = Convert.ToString(strMemNO);
            tblHaveClass_Header hea = new tblHaveClass_Header();
            if (bhch.isExistModel(cour, men) == false)
            {
                MessageBox.Show("对不起，目前还没有进行过任何课程，暂时不能收款！");
                return;
            }

            if (MessageBox.Show("收款金额前请确实金额额度和收款时间是否正确，是否继续?", "支付金额", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                hea.cid = bhch.GetCid(cour, men);
                hea.courseNo = cour;
                hea.userNO = men;
                hea.pMoney = Convert.ToDecimal(money);
                hea.endDateTime = Convert.ToString(datePayTime.Text);
                hea.ptype = "I";
                if (bhch.PayMoney(hea))
                {
                    MessageBox.Show("收款成功！");
                    paym();

                }
                else
                    MessageBox.Show("收款失败，请稍候再试！");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            Search();
            
        }

        public void Search()
        {
            if (string.IsNullOrEmpty(cbxCourse.Text))
            {
                MessageBox.Show("课程名不能为空！");
                return;
            }
            tblmenber mod = new tblmenber();
            mod.Utype = "U";
            mod.Uqq = Convert.ToString(cbxCourse.SelectedValue);
            //mod.UserNo = strMemNO;
            getDataListM(mod);
            setDefaultNums();
        }

        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataListM(tblmenber mod)
        {
            List<tblmenber> users = new List<tblmenber>();
            users = bmen.GetModels2(mod);
            dgvData2.Rows.Clear();
            if (users != null)
            {
                if (users.Count > 0)
                {

                    foreach (tblmenber u in users)
                    {
                        dgvData2.Rows.Add();

                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["UserNo"].Value = Convert.ToString(u.UserNo);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["ChineseName"].Value = Convert.ToString(u.ChineseName);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Uschool"].Value = Convert.ToString(u.Uschool);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Uclass"].Value = Convert.ToString(u.Uclass);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Umobile"].Value = Convert.ToString(u.Umobile);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Usex"].Value = Convert.ToString(u.Usex);
                        dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Uaddtime"].Value = Convert.ToString(u.Uaddtime);
                        
                    }
                }

            }
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add();
            dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value = true;
            dgvData.Rows[dgvData.Rows.Count - 1].Cells["startTime"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            dgvData.Rows[dgvData.Rows.Count - 1].Cells["classNum"].Value = dgvData.Rows.Count;
            dgvData.Rows[dgvData.Rows.Count - 1].Cells["amount"].Value = 0;
            dgvData.Rows[dgvData.Rows.Count - 1].Cells["isFinish"].Value = "N";
            save("");
            setBgColor();
        }


        public void save(string str)
        {
            int CountRows = 0;

            if (dgvData.Rows.Count > 0)
            {
                CountRows = dgvData.Rows.Count;
                if (str != "")
                    CountRows = dgvData.Rows.Count - 1;

                string cour = Convert.ToString(cbxCourse.SelectedValue);
                string men = Convert.ToString(strMemNO);

                tblHaveClass_Header hea = new tblHaveClass_Header();
                if (bhch.isExistModel(cour, men) == false)
                    hea.cid = bhch.GetMaxNo();
                else
                    hea.cid = bhch.GetCid(cour, men);
                tblCourse c = new tblCourse();
                tblmenber m = new tblmenber();
                c.courseNo = Convert.ToString(cbxCourse.SelectedValue);
                m.UserNo = Convert.ToString(strMemNO);
                hea.menber = m;
                hea.Course = c;
                List<tblHaveClass_Detail> _hcds = new List<tblHaveClass_Detail>();


                for (int i = 0; i < CountRows; ++i)
                {
                    tblHaveClass_Detail _hcd = new tblHaveClass_Detail();
                    _hcd.cid = hea.cid;
                    _hcd.startTime = Convert.ToString(dgvData.Rows[i].Cells["startTime"].Value);
                    _hcd.amount = Convert.ToString(dgvData.Rows[i].Cells["amount"].Value);
                    _hcd.classNum = Convert.ToString(dgvData.Rows[i].Cells["classNum"].Value);
                    _hcd.personCount = "0";
                    _hcd.isFinish = Convert.ToString(dgvData.Rows[i].Cells["isFinish"].Value);
                    _hcd.ctype = "I";
                    _hcds.Add(_hcd);
                }

                if (_hcds.Count > 0)
                    hea.HaveClass_Detail = _hcds;

                if (bhch.InsertModel(hea))
                {
                    getData();

                }
                else
                    MessageBox.Show("操作失败！");
            }
            else
            {
                MessageBox.Show("该成员还未上过任何课程，暂时不能保存！");
            }
        }


        private void btAddCourse_Click(object sender, EventArgs e)
        {
            FrmCourseQ frm = new FrmCourseQ(true);
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(frm.result))
            {
                get_Course();
                cbxCourse.SelectedValue = frm.result;
            }
        }

        //private void btTeah_Click(object sender, EventArgs e)
        //{
        //    FrmmenberQ frm = new FrmmenberQ(true, "U");
        //    frm.ShowDialog();
        //    if (!string.IsNullOrEmpty(frm.result))
        //    {
        //        get_menber();
        //        cbxTeah.SelectedValue = frm.result;
        //    }
        //}

        private void btClose_Click(object sender, EventArgs e)
        {
            if (btSave.Enabled == true)
            {
                if (MessageBox.Show("你修改了部分数据还未保存，是否继续关闭此窗口?", "关闭窗口", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    return;
                }

            }
            else
                this.Close();
        }


        public void paym()
        {
            string cour = Convert.ToString(cbxCourse.SelectedValue);
            string men = Convert.ToString(strMemNO);

            tblHaveClass_Header hea = new tblHaveClass_Header();
            if (bhch.isExistModel(cour, men) == false)
                hea.cid = bhch.GetMaxNo();
            else
                hea.cid = bhch.GetCid(cour, men);
            tblCourse c = new tblCourse();
            tblmenber m = new tblmenber();
            c.courseNo = Convert.ToString(cbxCourse.SelectedValue);
            m.UserNo = Convert.ToString(strMemNO);
            hea.menber = m;
            hea.Course = c;
            List<tblHaveClass_Detail> _hcds = new List<tblHaveClass_Detail>();

            if (dgvData.Rows.Count > 0)
            {
                for (int i = 0; i < dgvData.Rows.Count; ++i)
                {

                    if ((bool)dgvData.Rows[i].Cells[0].Value == true && Convert.ToString(dgvData.Rows[i].Cells["isFinish"].Value) == "N")
                    {
                        tblHaveClass_Detail _hcd = new tblHaveClass_Detail();
                        _hcd.cid = hea.cid;
                        _hcd.personCount = "0";
                        _hcd.startTime = Convert.ToString(dgvData.Rows[i].Cells["startTime"].Value);
                        _hcd.amount = Convert.ToString(dgvData.Rows[i].Cells["amount"].Value);
                        _hcd.classNum = Convert.ToString(dgvData.Rows[i].Cells["classNum"].Value);
                        _hcd.isFinish = Convert.ToString(dgvData.Rows[i].Cells["isFinish"].Value);
                        _hcds.Add(_hcd);
                    }
                }
            }
            if (_hcds.Count > 0)
                hea.HaveClass_Detail = _hcds;

            if (bhch.UpdateModel(hea))
            {
                getData();
            }
            else
                MessageBox.Show("操作失败！");
        }

        private void dgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    string amounts = Convert.ToString(dgvData.Rows[e.RowIndex].Cells["amount"].Value);

                    if (string.IsNullOrEmpty(amounts))
                    {
                        dgvData.Rows[e.RowIndex].Cells["amount"].Value = "0";
                    }
                    setTotalQty();
                    btSave.Enabled = true;
                }
            }

        }

        /// <summary>
        /// 上课后该条颜色着色
        /// </summary>
        public void setBgColor()
        {
            for (int i = 0; i < dgvData.Columns.Count; i++)
            {
                dgvData.Rows[dgvData.Rows.Count - 1].Cells[i].Style.BackColor = Color.LightBlue;
            }
        }

        /// <summary>
        /// 点击搜索后再启用按钮
        /// </summary>
        public void setBtEnable(bool enable)
        {
            btStart.Enabled = enable;
            btCollections.Enabled = enable;
            btSave.Enabled = enable;
            btDelete.Enabled = enable;
        }

        /// <summary>
        /// 初始化统计数值
        /// </summary>
        public void setDefaultNums()
        {
            tbxPayMonent.Text = "0";
            labPayMeny.Text = "0";
            labAmountTotal.Text = "0";
            labClassNums.Text = "0";
            dgvData.Rows.Clear();
        }

        private void cbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbxCourse.Text))
            {
                setBtEnable(false);
                Search();
                setTotalQty();
            }
        }

        private void cbxTeah_SelectedIndexChanged(object sender, EventArgs e)
        {
            setBtEnable(false);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            save("");
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
            setTotalQty();
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
                    setTotalQty();
                }
            }
        }

        private void dgvData2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData2.Rows.Count > 0 && e.RowIndex!=-1)
            {
                strMemNO = Convert.ToString(dgvData2.Rows[e.RowIndex].Cells["UserNo"].Value??"");
                getData();
                setTotalQty();
                setBtEnable(true);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除吗？","删除",MessageBoxButtons.YesNo)==DialogResult.Yes)
                save("del");
        }
    }
}
