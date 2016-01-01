using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;
using System.Threading;


namespace trainNewSun
{
    public class B_SMSList
    {
        tblSMSList sms = new tblSMSList();

        public bool InsertModel(tblSMSList model)
        {
            bool result = false;
            string sql = "insert into tblSMSList(" + model.Fields + ")values('" + model.title + "','" + model.content + "')";
            if (OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null) != -1)
                result = true;
            return result;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<tblSMSList> getModels()
        {
            List<tblSMSList> smslists = new List<tblSMSList>();
            string sql = "select " + new tblSMSList().Fields + ",createtime  from tblSMSList order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                smslists.Add(new tblSMSList { title = Convert.ToString(dr["title"]), content = Convert.ToString(dr["content"]), createtime = Convert.ToString(dr["createtime"]) });
            }
            return smslists;
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
                list_tetrads.ForEach(n =>
                {
                    SMS_msg msg = new SMS_msg();
                    msg = sms;
                    msg.phones = n;
                    new B_SMS().ToMobile(msg);
                    Thread.Sleep(1000);
                });
            });

        }

        public Func<List<string>, int, int, List<string>> countSMSpones = (t, c1, c2) =>
        {
            List<string> nums = new List<string>();
            for (int i = c1; i <= c2; i++)
            {
                nums.Add(t[i]);
            }
            return nums;

        };


    }
}
