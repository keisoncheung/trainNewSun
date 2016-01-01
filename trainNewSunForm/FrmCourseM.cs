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
    public partial class FrmCourseM : Form
    {
       tblCourse model = new tblCourse();
       B_tblCourse bmodel = new B_tblCourse();
        public bool result=false;
        public string strItemNO = "";
        public FrmCourseM(string itemno)
        {
            InitializeComponent();
            strItemNO = itemno;
            loadData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            if (string.IsNullOrEmpty(strItemNO))
            {
                tbxBrandNo.Text = bmodel.GetMaxNo();
            }
            else
                getData();
        }


        /****************************/

        public void Save()
        {
            string val = tbxBrandNo.Text.Trim();
            string text = tbxBrandName.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("课程名不能为空！");
                return;
            }
            tblCourse mod = new tblCourse();
            mod.courseNo = val;
            mod.courseName = text;
            if (bmodel.isExistModel(val) == true)
            {
                if (bmodel.UpdateModel(mod) == true)
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.COU + "", val + "更新成功！");
                    result = true;
                }
            }
            else
            {
                if (bmodel.InsertModel(mod) == true)
                {
                    SystemInfo.Log(SystemInfo.MsgType.Type.COU + "", val + "添加成功！");
                    result = true;
                }
            }
            this.Close();
        }


        public void getData()
        {
            tblCourse mod = new tblCourse();
            mod = bmodel.GetFullInfo(strItemNO);
            if (mod != null)
            {
                tbxBrandNo.Text = Convert.ToString(mod.courseNo);
                tbxBrandName.Text = Convert.ToString(mod.courseName);
            }
        }

        private void btColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            tbxBrandNo.Text = bmodel.GetMaxNo();
            tbxBrandName.Text = string.Empty;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
