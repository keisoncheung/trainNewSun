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
    public partial class FrmIncomeM : Form
    {
        tblIncome model = new tblIncome();
        B_tblIncome bmodel = new B_tblIncome();
        tblmenber men = new tblmenber();
        B_tblmenber bmen = new B_tblmenber();
        tblIncomeType tit = new tblIncomeType();
        B_tblIncomeType btit = new B_tblIncomeType();
        FrmMain main;
        public string strItemNO = "";
        public bool result = false;
        string utype = "O";

        public FrmIncomeM(FrmMain parent)
        {
            InitializeComponent();

            this.MdiParent = parent;
            loadData();

        }
        public FrmIncomeM(string uno, string stype)
        {
            InitializeComponent();


            utype = stype;
            strItemNO = uno;
            loadData();


        }


        public FrmIncomeM(FrmMain parent, string stype)
        {
            InitializeComponent();
            utype = stype;
            if (stype == "I")
                this.Text = "财务收入";
            else
                this.Text = "财务支出";
            loadData();
           
           
        }

        /*********************************/

        public void loadData()
        {
            getData();
        }

        public void getData()
        {
            get_cbxistype();
            get_menber();
            getDataList();
        }

        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataList()
        {
            tblIncome u = new tblIncome();
            u = bmodel.GetFullInfo(strItemNO);
            if (u != null)
            {
                tbxBrandName.Text = u.itest;
                cbxistype.Text = u.icometype;
                cbxTeah.Text = u.imenber;
                tbxamounts.Text = u.amounts;
            }
        }
        public void get_menber()
        {
            List<tblmenber> listData = new List<tblmenber>();
            List<tblmenber> listData2 = new List<tblmenber>();
            tblmenber _m = new tblmenber();
            _m.Utype = "P";
            listData = bmen.GetModels(_m);
            if (listData.Count > 0)
            {
                foreach (tblmenber v_data in listData)
                {
                    tblmenber data = new tblmenber();
                    data.UserNo = Convert.ToString(v_data.UserNo);
                    data.ChineseName = Convert.ToString(v_data.ChineseName);
                    listData2.Add(data);
                }
            }
            cbxTeah.DataSource = null;
            cbxTeah.DataSource = listData2;
            cbxTeah.DisplayMember = "ChineseName";
            cbxTeah.ValueMember = "UserNo";

        }

        public void get_cbxistype()
        {
            List<tblIncomeType> listData = new List<tblIncomeType>();
            List<tblIncomeType> listData2 = new List<tblIncomeType>();
            tblIncomeType _m = new tblIncomeType();
            _m.IType = utype;
            listData = btit.GetModels(_m);
            if (listData.Count > 0)
            {
                foreach (tblIncomeType v_data in listData)
                {
                    tblIncomeType data = new tblIncomeType();
                    data.IncomeNo = Convert.ToString(v_data.IncomeNo);
                    data.IncomeName = Convert.ToString(v_data.IncomeName);
                    listData2.Add(data);
                }
            }
            cbxistype.DataSource = null;
            cbxistype.DataSource = listData2;
            cbxistype.DisplayMember = "IncomeName";
            cbxistype.ValueMember = "IncomeNo";

        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        public void add()
        {
            tblIncome u = new tblIncome();
            tbxBrandName.Text = string.Empty;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            save();
            //string str="";
            //string FirstChar = "I";
            //string sql = "select (iNo) from tblIncome";
            //DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            //foreach (DataRow dr in dt.Rows)
            //{
            //    str=FirstChar+"00000"+Convert.ToString(dr[0]).Substring(1);

            //    OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, "update tblIncome set ino='" + str + "' where ino='" + dr[0] + "'", null);
            //}
        }

        public void save()
        {

            string stristype = Convert.ToString(cbxistype.Text);
            string striTest = Convert.ToString(tbxBrandName.Text);
            string strimenber = Convert.ToString(cbxTeah.Text);
            string strAddDate = dateAddDate.Text;
            tblIncome mod = new tblIncome();
            string stramounts = tbxamounts.Text.Trim();
            if (string.IsNullOrEmpty(striTest))
            {
                MessageBox.Show("记账名称不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(stristype))
            {
                MessageBox.Show("类别不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(strimenber))
            {
                MessageBox.Show("生意伙伴不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(stramounts))
            {
                MessageBox.Show("金额不能为空！");
                return;
            }


            mod.itest = striTest;
            mod.itype = utype;
            mod.icometype = stristype;
            string striNo = bmodel.GetMaxNo();
            mod.iNo = striNo;
            mod.createDateTime = strAddDate;
            mod.amounts = stramounts;
            mod.imenber = strimenber;

            if (bmodel.isExistModel(striNo) == true)
            {
                tblIncome U = new tblIncome();
                U = bmodel.GetFullInfo(striNo);
                if (U != null)
                {
                    if (U.iNo != striNo)
                    {
                        MessageBox.Show("该记录已存在，不能重复添加！");
                        tbxBrandName.Focus();
                        return;
                    }

                    if (bmodel.UpdateModel(mod))
                    {
                        SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", striNo + "更新成功！");
                        result = true;
                        MessageBox.Show("更新成功！");
                    }
                    else
                    {
                        SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", striNo + "更新失败！");
                        result = false;
                        MessageBox.Show("更新失败！");
                    }
                }
            }
            else
            {
                if (bmodel.InsertModel(mod) == true)
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", striNo + "添加成功！");
                    result = true;
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.USR + "", striNo + "添加失败！");
                    result = false;
                    MessageBox.Show("添加失败！");
                }
            }

        }



    }
}

