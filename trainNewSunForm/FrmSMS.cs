using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using PublicHelper;

namespace trainNewSun
{
    public partial class FrmSMS : Form
    {
        FrmMain main;
        bool result = false;
        
        public FrmSMS(FrmMain parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //new B_SMS().sendmail("372707575@qq.com", "LZX短信群发通知", "发送条数：0；剩余条数:" + new B_tblAdmin().GetFullInfo("LZX").smsNums + "");
            //return;
            int nums = SystemInfo.getSMSNums();
            if (nums == 0)
            {
                MessageBox.Show("您的短信量为0，请充值！", "提示");
                return;
            }

            if (string.IsNullOrEmpty(tbxContent.Text.Trim()))
            {
                MessageBox.Show("短信内容不能为空！", "提示");
                return;
            }
            //if (!IsSendTime())
            //{
            //    MessageBox.Show("发送短信请在白天9：00——17:30之间发送！");
            //    return;
            //} 
            
            if (MessageBox.Show("是否提交发送？", "确定发送", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nums <50)
                {
                    MessageBox.Show("您的短信量已不足50条，为了避免因不够扣量而导致发送内容的失败，请及时充值！");
                }
                
                

                SMS_msg sms = new SMS_msg();
                sms.content=tbxContent.Text.Trim();
                List<string> strnums = new List<string>();
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    if ((bool)dgvData.Rows[i].Cells[0].Value==true)
                        strnums.Add(Convert.ToString(dgvData.Rows[i].Cells[2].Value));
                }

                 for (int i = 0; i < dgvData3.Rows.Count; i++)
                {
                    if ((bool)dgvData3.Rows[i].Cells[0].Value == true)
                        strnums.Add(Convert.ToString(dgvData3.Rows[i].Cells[2].Value));
                }

                 if (strnums.Count<=0)
                {
                    MessageBox.Show("手机号码不能为空！", "提示");
                    return;
                }

                 sms.phones=strnums;
                 if (strnums.Count * new B_SMS().CountNums(sms.content) > nums)
                 {
                     MessageBox.Show("您的短信剩余量不足扣发本次的短信量，请尽快充值！");
                     return;
                 }
                sendto(sms);
                
            }
        }

       

        private bool IsSendTime()
        {
            bool result = true;
            if (DateTime.Now.Hour < 9 || Convert.ToDouble(DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString()) > 17.30)
                result = false;
            return result;
        }

        public void sendto(SMS_msg sms)
        {
            List<List<string>> list_tetrads = new List<List<string>>();

            if (sms.phones.Count <= 100)
            {
                list_tetrads.Add(sms.phones);
            }
            else
            {
                int j = sms.phones.Count / 100;
                int x = 0;
                for (int z = 0; z < j; z++)
                {
                    x = z * 100;
                    list_tetrads.Add(countSMSpones(sms.phones, x, (x + 100) - 1));
                }
                list_tetrads.Add(countSMSpones(sms.phones, j * 100, sms.phones.Count - 1));

            }

            new System.Threading.Tasks.TaskFactory().StartNew(() =>
                {
                    list_tetrads.ForEach(n => {
                        SMS_msg msg = new SMS_msg();
                        msg = sms;
                        msg.phones = n;
                        new B_SMS().ToMobile(msg);
                        Thread.Sleep(1000);
                    });

                }).ContinueWith(t => saveSMSList(sms));
        }

        public Func<List<string>, int, int, List<string>> countSMSpones = (t, c1, c2) => {
            List<string> nums = new List<string>();
            for (int i = c1; i <= c2; i++)
            {
                nums.Add(t[i]);
            }
            return nums;
       
        };

        public void saveSMSList(SMS_msg sms)
        {
            if (sms != null)
            {
                if (new B_SMSList().InsertModel(new tblSMSList { content = string.Join(",",sms.phones.ToArray()), title = sms.content }))
                    MessageBox.Show("发送成功! 此批短信已被服务器接纳，并已进入队列。", "提示");
                else
                    MessageBox.Show("发送失败!", "提示");
            }
 
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            FrmmenberQ frm = new FrmmenberQ(true, "U");
            frm.ShowDialog();
            if (frm.unserNos != null)
            {
                //dgvData.Rows.Clear();
                setNums(new B_tblmenber().GetNums(frm.unserNos));
            }

        }

        public void setNums(List<tblmenber> nums)
        {
            if (nums != null && nums.Count > 0)
            {
                List<tblmenber> preUsers = new List<tblmenber>();
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    preUsers.Add((tblmenber)dgvData.Rows[i].Tag);
                }
                nums.ForEach(n =>
                {
                    if (!preUsers.Exists(p=>p.UserNo.Equals(n.UserNo)))
                    {
                        dgvData.Rows.Add();
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value = true;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells[1].Value = n.ChineseName;
                        dgvData.Rows[dgvData.Rows.Count - 1].Cells[2].Value = n.Umobile;
                        dgvData.Rows[dgvData.Rows.Count - 1].Tag = n;
                    }
                });
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void dgvData2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxphonesUnder.Text = string.Empty;
            if (dgvData2.Rows.Count > 0 && e.RowIndex != -1)
            {
                tbxphonesUnder.Text = ((tblSMSList)dgvData2.Rows[e.RowIndex].Tag).content;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                List<tblSMSList> sms = new B_SMSList().getModels();
                 dgvData2.Rows.Clear();
                sms.ForEach(s => {
                    dgvData2.Rows.Add();
                    dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["title"].Value = s.title;
                    dgvData2.Rows[dgvData2.Rows.Count - 1].Cells["createtime"].Value = s.createtime;
                    dgvData2.Rows[dgvData2.Rows.Count - 1].Tag = s;
                });
            }
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                for (int i = dgvData.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)dgvData.Rows[i].Cells[0].Value == true)
                    {
                        dgvData.Rows.Remove(dgvData.Rows[i]);
                    }
                }
            }
        }

        private void cbxCheckAll2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheckAll2.Checked == true)
            {
                func_CheckAll2(true);
                cbxCheckAll2.Text = "全消";
            }
            else
            {
                func_CheckAll2(false);
                cbxCheckAll2.Text = "全选";
            }
        }

        public void func_CheckAll2(bool chek)
        {
            for (int i = 0; i < dgvData3.Rows.Count; i++)
            {
                dgvData3.Rows[i].Cells[0].Value = chek;
            }
        }

        private void bt_Del2_Click(object sender, EventArgs e)
        {
            if (dgvData3.Rows.Count > 0)
            {
                for (int i = dgvData3.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)dgvData3.Rows[i].Cells[0].Value == true)
                    {
                        dgvData3.Rows.Remove(dgvData3.Rows[i]);
                    }
                }
            }
        }

        private void btAddHM_Click(object sender, EventArgs e)
        {
            FrmmenberQ frm = new FrmmenberQ(true, "H");
            frm.ShowDialog();
            if (frm.unserNos != null)
            {
                //dgvData.Rows.Clear();
                setNums2(new B_tblmenber().GetNums(frm.unserNos));
            }


        }

        public void setNums2(List<tblmenber> nums)
        {
            if (nums != null && nums.Count > 0)
            {
                List<tblmenber> preUsers = new List<tblmenber>();
                for (int i = 0; i < dgvData3.Rows.Count; i++)
                {
                    preUsers.Add((tblmenber)dgvData3.Rows[i].Tag);
                }


                nums.ForEach(n =>
                {
                    if (!preUsers.Exists(p=>p.UserNo.Equals(n.UserNo)))
                    {
                        dgvData3.Rows.Add();
                        dgvData3.Rows[dgvData3.Rows.Count - 1].Cells[0].Value = true;
                        dgvData3.Rows[dgvData3.Rows.Count - 1].Cells[1].Value = n.ChineseName;
                        dgvData3.Rows[dgvData3.Rows.Count - 1].Cells[2].Value = n.Umobile;
                        dgvData3.Rows[dgvData3.Rows.Count - 1].Tag = n;
                    }
                });
            }
        }

        private void dgvData3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData3.CurrentCell != null)
            {
                if (e.ColumnIndex == 0)
                {
                    if ((bool)dgvData3.Rows[e.RowIndex].Cells[0].Value == false)
                        dgvData3.Rows[e.RowIndex].Cells[0].Value = true;
                    else
                        dgvData3.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btAutoSend_Click(object sender, EventArgs e)
        {
            if (!IsSendTime())
            {
                MessageBox.Show("发送短信请在白天9：00——17:30之间发送！");
                return;
            }
            if (MessageBox.Show("是否提交发送？", "确定发送", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AutoSendSMS();
            }
        }

        public void AutoSendSMS()
        {
            List<tblmenber> users = new List<tblmenber>();
            SMS_msg sms = new SMS_msg();
            sms.content = new B_tblAdmin().GetFullInfo("LZX").smsContent;
            sms.phones = new List<string>();
            users = new B_tblmenber().GetModels(new tblmenber { S_flag = "N" });
            users.Where(s => { return RexHelper.IsMatch(Convert.ToString(s.Umobile), RexHelper.rexType.Phone); }).ToList().ForEach(t =>
            {
                sms.phones.Add(Convert.ToString(t.Umobile));
                new B_tblmenber().UpdateS_FLAG(t.UserNo);
            });
            sendto(sms);

        }

        private void btGetNums_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前短信条数："+new B_tblAdmin().GetFullInfo(SystemInfo.LoginUser).smsNums);
        }
    }
}
