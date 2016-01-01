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
    public partial class FrmIncomeQ : Form
    {
        tblIncome model = new tblIncome();
        B_tblIncome bmodel = new B_tblIncome();
        tblAdmin tamodel = new tblAdmin();
        B_tblAdmin btamodel = new B_tblAdmin();
        FrmMain main;
        tblHaveClass_Header hch = new tblHaveClass_Header();
        B_tblHaveClass bhc = new B_tblHaveClass();
        decimal amoney = 0;
        public FrmIncomeQ(FrmMain frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;
            main = frmParent;
            loadData();
            
        }

        public void loadData()
        {
            createDateTimeS.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-01";
            createDateTimeS2.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-01";

            getMoneyAdmin();
            countAmounts();
            getData();
            getData2();
        }

        public void getMoneyAdmin()
        {
            tblAdmin u = new tblAdmin();
            u = btamodel.GetFullInfo(SystemInfo.LoginUser);
            if (u != null)
                amoney = Convert.ToDecimal(u.A_money);

        }

        public void countAmounts()
        {

            labTotalCC.Text = (bmodel.getAmounts("", "", "") + amoney).ToString();
            labCashInB.Text = bmodel.getAmounts("","", "I").ToString();
            labCashOutB.Text  = bmodel.getAmounts("", "", "O").ToString();
        }


        public void getData()
        {
            string istype = ""; 
            decimal _labCashInS = 0;
            decimal _labCashOutS = 0;
            string dtStart=Convert.ToDateTime(createDateTimeS.Value).ToString("yyyy-MM-dd");
            string dtEnd = Convert.ToDateTime(createDateTimeE.Value).ToString("yyyy-MM-dd");
            List<tblIncome> icoms = new List<tblIncome>();
            tblIncome _ic = new tblIncome();
            _ic.dateStart = Convert.ToDateTime(dtStart);
            _ic.dateEnd = Convert.ToDateTime(dtEnd);
            if(!string.IsNullOrEmpty(istype))
                _ic.itype = istype;
            icoms = bmodel.GetModels2(_ic);
            dgvData.Rows.Clear();
            if (icoms != null)
            {
                
                foreach (tblIncome _icoms in icoms)
                {
                    dgvData.Rows.Add();
                    if (_icoms.itype == "I")
                    {
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsIN"].Value = _icoms.amounts;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsOUT"].Value = "";
                    }
                    else
                    {
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsIN"].Value = "";
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsOUT"].Value = _icoms.amounts;
                    }
                    dgvData.Rows[dgvData.Rows.Count - 1].Cells["createDateTime"].Value = _icoms.createDateTime;
                    dgvData.Rows[dgvData.Rows.Count - 1].Cells["icometype"].Value = _icoms.icometype;
                    dgvData.Rows[dgvData.Rows.Count - 1].Cells["imenber"].Value = _icoms.imenber;
                    dgvData.Rows[dgvData.Rows.Count - 1].Cells["itest"].Value = _icoms.itest;
                    _labCashInS += Convert.ToDecimal((string.IsNullOrWhiteSpace(Convert.ToString(dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsIN"].Value))) ? "0" : Convert.ToString(dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsIN"].Value));
                    _labCashOutS += Convert.ToDecimal((string.IsNullOrWhiteSpace(Convert.ToString(dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsOUT"].Value))) ? "0" : Convert.ToString(dgvData.Rows[dgvData.Rows.Count - 1].Cells["amountsOUT"].Value));
                }
            }

            labCashInS.Text = Convert.ToString(_labCashInS);
            labCashOutS.Text = Convert.ToString(_labCashOutS);


            countAmounts();

        }

        public void getData2()
        {
            string istype = "";
            decimal _labCashInS2 = 0;
            decimal _labCashOutS2 = 0;
            string dtStart = Convert.ToDateTime(createDateTimeS2.Value).ToString("yyyy-MM-dd");
            string dtEnd = Convert.ToDateTime(createDateTimeE2.Value).ToString("yyyy-MM-dd");
            List<tblHaveClass_Header> icoms = new List<tblHaveClass_Header>();
            tblHaveClass_Header _ic = new tblHaveClass_Header();
            _ic.startDateTime = Convert.ToDateTime(dtStart);
            _ic.endDateTime2 = Convert.ToDateTime(dtEnd);
            if (!string.IsNullOrEmpty(istype))
                _ic.ctype = istype;
            icoms = bhc.GetModels(_ic);
            dgvData2.Rows.Clear();
            if (icoms != null)
            {

                foreach (tblHaveClass_Header _icoms in icoms)
                {
                    
                    if(_icoms.HaveClass_Detail!=null)
                    {
                        foreach(tblHaveClass_Detail _icomsD in _icoms.HaveClass_Detail)
                        {
                            dgvData2.Rows.Add();
                            if (_icomsD.ctype == "I")
                            {
                                dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountIN"].Value = _icomsD.amount;
                                dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountOUT"].Value = "";
                            }
                            else
                            {
                                dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountIN"].Value = "";
                                dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountOUT"].Value = _icomsD.amount;
                            }
                            dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["startTime"].Value = _icomsD.startTime;
                            dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["courseNo"].Value = _icoms.Course.courseName;
                            dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["userNO"].Value = _icoms.menber.ChineseName;
                            dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["Uway"].Value = _icoms.menber.Uway;
                            _labCashInS2 += Convert.ToDecimal((string.IsNullOrWhiteSpace(Convert.ToString(dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountIN"].Value))) ? "0" : Convert.ToString(dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountIN"].Value));
                            _labCashOutS2 += Convert.ToDecimal((string.IsNullOrWhiteSpace(Convert.ToString(dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountOUT"].Value))) ? "0" : Convert.ToString(dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["amountOUT"].Value));

                        }
                    }
                }
            }

            labCashInS2.Text = Convert.ToString(_labCashInS2);
            labCashOutS2.Text = Convert.ToString(_labCashOutS2);

            countAmounts();

        }






        private void btColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void cbxctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData2();
        }

        private void cbxistype_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void btSearch2_Click(object sender, EventArgs e)
        {
            getData2();
        }

    }
}
