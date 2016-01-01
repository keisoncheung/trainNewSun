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
    public partial class FrmCourseQ : Form
    {
        tblCourse model = new tblCourse();
        B_tblCourse bmodel = new B_tblCourse();
        public bool isGetRelt = false;//是否要返回值
        public string result = string.Empty;

        public FrmCourseQ(FrmMain frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;
            loadData();
        }

        public FrmCourseQ(bool isGet)
        {
            InitializeComponent();
            loadData();
            isGetRelt = isGet;
            setBtDisplay();
        }

        /*********************************/

        public void setBtDisplay()
        {
            if (isGetRelt == true)
            {
                btChoose.Visible = true;
                tsstorChoose.Visible = true;
                btEdit.Visible = false;
                tsstorEdit.Visible = false;
            }

        }


        public void loadData()
        {

            loadDataList();
        }

        public void loadDataList()
        {
            getDataList(new tblCourse());
        }

        /// <summary>
        /// 列表数据
        /// </summary>
        /// <param name="mod"></param>
        public void getDataList(tblCourse mod)
        {
            List<tblCourse> brands = new List<tblCourse>();
            brands = bmodel.GetModels(mod);
            tvwData.Nodes.Clear();
            TreeNode node1=new TreeNode();
            node1.Text = "课程";
            if (brands.Count > 0)
            {
                foreach (tblCourse br in brands)
                {
                    node1.Nodes.Add(Convert.ToString(br.courseNo),Convert.ToString(br.courseName));
                }
                tvwData.Nodes.Add(node1);
            }
            tvwData.ExpandAll();
        }





        private void btAdd_Click(object sender, EventArgs e)
        {
            showFrmBrandM();
        }

        public void showFrmBrandM()
        {
            FrmCourseM frm = new FrmCourseM("");
            frm.ShowDialog();
            getDataList(new tblCourse());

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (tvwData.SelectedNode != null)
            {
                int lv = tvwData.SelectedNode.Level;
                if (lv == 1)
                {
                    FrmCourseM frm = new FrmCourseM(tvwData.SelectedNode.Name);
                    frm.ShowDialog();
                    getDataList(new tblCourse());
                }
                else
                    MessageBox.Show("根节点不能修改！");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_Name_KeyDown(object sender, KeyEventArgs e)
        {

            string str = tbx_Name.Text.Trim();

            if (e.KeyData == Keys.Enter)
            {
                tblCourse mod = new tblCourse();
                if (!string.IsNullOrEmpty(str))
                    mod.courseName = str;
                getDataList(mod);
            }

        }

        private void btDelte_Click(object sender, EventArgs e)
        {
            //if (tvwData.SelectedNode != null)
            //{
            //    int lv = tvwData.SelectedNode.Level;
            //    if (lv == 1)
            //    {
            //        string val = tvwData.SelectedNode.Name;
            //        if (MessageBox.Show("确定要删除吗?", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            if (model.ExistExchange(val) == false)
            //            {
            //                if (model.Delete(val) == true)
            //                {
            //                    SystemInfo.Log(SystemInfo.MsgType.Type.BRD + "", val + "删除成功！");
            //                    getDataList(new Brand());
            //                }
            //                else
            //                    MessageBox.Show("删除失败！");
            //            }
            //            else
            //                MessageBox.Show("该品牌存在交易记录，暂时不能删除！");
            //        }
            //    }
            //}
        }

        private void tvwData_DoubleClick(object sender, EventArgs e)
        {
            Choose();
        }

        public void Choose()
        {
            if (isGetRelt == true)
            {
                if (tvwData.SelectedNode != null)
                {
                    int lv = tvwData.SelectedNode.Level;
                    if (lv == 1)
                    {
                        result = tvwData.SelectedNode.Name;
                        this.Hide();
                    }
                    else
                        MessageBox.Show("不能选择根节点！");
                }
                else
                    MessageBox.Show("请至少选择一项！");
            }
        }

        private void tbx_Name_TextChanged(object sender, EventArgs e)
        {
            string keyw = tbx_Name.Text.Trim();
            if (string.IsNullOrEmpty(keyw))
                getDataList(new tblCourse());
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            Choose();
        }


    }
}
