using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblmenber:BusinessBase
    {

        tblmenber AM = new tblmenber();


    
        public string GetMaxNo(string utype)
        {
            int intLen = 7;
            string FirstChar = utype;
            string no = "";
            string strSQL = "";
            try
            {
                strSQL = "select Max(UserNo) as MaxUserNo from tblmenber where utype='"+utype+"'";
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
                if (dt.Rows[0]["MaxUserNo"].ToString() == "")
                {
                    no = FirstChar + "1".PadLeft(intLen - FirstChar.Length, '0');
                }
                else
                {
                    int intTmp = Convert.ToInt32(dt.Rows[0]["MaxUserNo"].ToString().Substring(FirstChar.Length, intLen - FirstChar.Length));
                    intTmp = intTmp + 1;
                    no = FirstChar + intTmp.ToString().PadLeft(intLen - FirstChar.Length, '0');
                }
                return no;
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
                return null;
            }
        }

        public bool isExistModel(string No)
        {
            string strSQL = "";
            strSQL = "select top 1 UserNo from tblmenber where UserNo='" + No + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertModel(tblmenber model)
        {
            bool result = false;

            string sql = "insert into tblmenber(" + AM.Fields + ")values('" + model.Utype + "','" + model.UserNo + "','" + model.Usex + "','" + model.ChineseName + "','" + model.Umobile + "','" + model.Uqq + "','" + model.Uschool + "','" + model.Uclass + "','" + model.Uaddtime + "','" + model.Uway + "','" + model.Valid + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + Convert.ToString(model.S_flag) + "',null)";
             try
             {
               
                 OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                 result = true;
                 SendSMSforM(Convert.ToString(model.Umobile));
             }
             catch(Exception ee)
             {
           
             }
            return result;
        }

        public void SendSMSforM(string phoneNo)
        {
            if (!string.IsNullOrWhiteSpace(phoneNo) && RexHelper.IsMatch(phoneNo.Trim(), RexHelper.rexType.Phone))
            {
                List<string> str = new List<string>();
                str.Add(phoneNo.Trim());
                new System.Threading.Tasks.TaskFactory().StartNew(() =>
                {
                    new B_SMS().ToMobile(new SMS_msg { content = new B_tblAdmin().GetFullInfo("LZX").smsContent, phones = str }); 
                });
            }
        }

        public bool DelModels(List<string> unos)
        {
            bool bol = true;

            unos.ForEach(m =>
            {
                if (OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, "delete from tblmenber where UserNo='" + m + "'; ", null) == -1)
                    bol = false;
            });
            return bol;
            
        }

        public bool UpdateModel(tblmenber model)
        {
            bool result = false;
            List<string> sbr = new List<string>();
            string sql="";
            if (model != null)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(model.Utype))) sbr.Add(" Utype='" + model.Utype + "'");
                if (!string.IsNullOrWhiteSpace(model.UserNo)) sbr.Add(" UserNo='" + model.UserNo + "'");
                if (!string.IsNullOrWhiteSpace(model.Usex)) sbr.Add(" Usex='" + model.Usex + "'");
                if (!string.IsNullOrWhiteSpace(model.ChineseName)) sbr.Add(" ChineseName='" + model.ChineseName + "'");
                if (!string.IsNullOrWhiteSpace(model.Uqq)) sbr.Add(" Uqq='" + model.Uqq + "'");
                if (!string.IsNullOrWhiteSpace(model.Uschool)) sbr.Add(" Uschool='" + model.Uschool + "'");
                if (!string.IsNullOrWhiteSpace(model.Uclass)) sbr.Add(" Uclass='" + model.Uclass + "'");
                if (!string.IsNullOrWhiteSpace(model.Uaddtime)) sbr.Add(" [Uaddtime]='" + model.Uaddtime + "'");
                if (!string.IsNullOrWhiteSpace(model.Uway)) sbr.Add(" [Uway]='" + model.Uway + "'");
                if (!string.IsNullOrWhiteSpace(model.Umobile)) sbr.Add(" [Umobile]='" + model.Umobile + "'");
                if (!string.IsNullOrWhiteSpace(model.Valid)) { sbr.Add(" [Valid]='"+model.Valid+"'"); };
                if (!string.IsNullOrWhiteSpace(model.S_flag)) { sbr.Add(" s_flag='" + model.S_flag + "' "); };
                if (!string.IsNullOrWhiteSpace(model.SigninTime)) { sbr.Add(" SigninTime='" + model.SigninTime + "' "); };
                sbr.Add(" EditDateTime='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
                sql = "update tblmenber set " + string.Join(",", sbr.ToArray()) + " where UserNo='" + model.UserNo + "'";
                try
                {
                    
                    OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                    result = true;
                }
                catch (Exception ee)
                {

                }
            }
            return result;
        }

        /// <summary>
        /// 保存短信发送状态
        /// </summary>
        /// <param name="UserNo"></param>
        public void UpdateS_FLAG(string UserNo)
        {
            string sql = "update tblmenber set s_flag='Y'  where UserNo='" + UserNo + "'";
            OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
        }


        /// <summary>
        /// 保存短信发送状态
        /// </summary>
        /// <param name="UserNo"></param>
        public bool UpdateS_Signin(string UserNo, string dtime)
        {
            bool bol = false;
            string sql = "update tblmenber set SigninTime='" + dtime + "'  where UserNo='" + UserNo + "'";
            try
            {
                OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                bol = true;
            }
            catch (Exception ee)
            {
 
            }
            return bol;
        }


        /// <summary>
        /// BY UserNo
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public tblmenber GetFullInfo(string Name)
        {
            tblmenber _user = new tblmenber();
            string strSQL = "select " + AM.Fields + " from tblmenber  where UserNo='" + Name + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _user.UserNo = Convert.ToString(dt.Rows[0]["UserNo"]);
                _user.Utype = Convert.ToString(dt.Rows[0]["Utype"]);
                _user.ChineseName = Convert.ToString(dt.Rows[0]["ChineseName"]);
                _user.Usex = Convert.ToString(dt.Rows[0]["Usex"]);
                _user.Uqq = Convert.ToString(dt.Rows[0]["Uqq"]);
                _user.Uclass = Convert.ToString(dt.Rows[0]["Uclass"]);
                _user.Umobile = Convert.ToString(dt.Rows[0]["Umobile"]);
                _user.Uschool = Convert.ToString(dt.Rows[0]["Uschool"]);
                _user.Uaddtime = Convert.ToString(dt.Rows[0]["Uaddtime"]);
                _user.Uway = Convert.ToString(dt.Rows[0]["Uway"]);
                _user.Valid = Convert.ToString(dt.Rows[0]["Valid"]);
                _user.EditDateTime = Convert.ToString(dt.Rows[0]["EditDateTime"]);
                _user.S_flag = Convert.ToString(dt.Rows[0]["s_flag"]);

            }
            else
            {
                _user = null;

            }
            return _user;
        }

        public List<tblmenber> GetModels(tblmenber model,string s_flag=null)
        {
            List<tblmenber> menbers = new List<tblmenber>();
            List<string> where =new List<string>();
            string strwhere="";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.UserNo))
                {
                        where.Add(" userno like '%" + model.UserNo + "%' ");
                }
                if (!string.IsNullOrEmpty(model.Uqq))
                {
                    where.Add(" Uqq like '%" + model.Uqq + "%' ");
                }

                if (!string.IsNullOrEmpty(model.ChineseName))
                {
                    where.Add(" ChineseName like '%" + model.ChineseName + "%' ");
                }
                if (!string.IsNullOrEmpty(model.Uschool))
                {
                    where.Add(" Uschool like '%" + model.Uschool + "%' ");
                }
                if (!string.IsNullOrEmpty(model.Uclass))
                {
                    where.Add(" Uclass like '%" + model.Uclass + "%' ");
                }

                

                if (where.Count > 0)
                {
                    strwhere = " where " + string.Join(" or ", where.ToArray());
                    if (!string.IsNullOrEmpty(model.Utype))
                    {

                        strwhere += " and  Utype = '" + model.Utype + "' ";
                    }
                }
                else
                {
                    strwhere += " where  Utype = '" + model.Utype + "' ";
                }


                if (!string.IsNullOrWhiteSpace(model.S_flag))
                    strwhere = " where  s_flag='" + model.S_flag + "' ";

            }
            string sql = "select "+AM.Fields+" from tblmenber "+strwhere+" order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblmenber m = new tblmenber();
                m.UserNo = Convert.ToString(dr["UserNo"]);
                m.Uschool = Convert.ToString(dr["Uschool"]);
                m.ChineseName = Convert.ToString(dr["ChineseName"]);
                m.Uclass = Convert.ToString(dr["Uclass"]);
                m.Umobile = Convert.ToString(dr["Umobile"]);
                m.Uqq = Convert.ToString(dr["Uqq"]);
                m.Uaddtime = Convert.ToDateTime(dr["Uaddtime"]).ToString("yyyy-MM-dd");
                m.EditDateTime = Convert.ToDateTime(dr["EditDateTime"]).ToString("yyyy-MM-dd");
                m.Utype = Convert.ToString(dr["Utype"]);
                m.Uway = Convert.ToString(dr["Uway"]);
                m.Usex = Convert.ToString(dr["Usex"]);
                m.Valid = (Convert.ToString(dr["Valid"]) == "Y") ? "启用中" : "失效中";
                m.S_flag = Convert.ToString(dr["s_flag"]);
                if (!string.IsNullOrWhiteSpace(Convert.ToString(dr["SigninTime"])))
                {
                    if (DateTime.Compare(DateTime.Now.Date, Convert.ToDateTime(dr["SigninTime"]).Date) == 0)
                        m.SigninTime = Convert.ToString(dr["SigninTime"]);
                    else
                        m.SigninTime = string.Empty;
                }
                else
                    m.SigninTime = string.Empty;
                menbers.Add(m);
            }
            return menbers;
        }


        public List<tblmenber> GetModels2(tblmenber model)
        {
            List<tblmenber> menbers = new List<tblmenber>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.UserNo))
                {
                    where.Add(" userno like '%" + model.UserNo + "%' ");
                }
                if (!string.IsNullOrEmpty(model.Uqq))
                {
                    where.Add(" Uqq like '%" + model.Uqq + "%' ");
                }

                if (where.Count > 0)
                {
                    strwhere = " where " + string.Join(" and ", where.ToArray());
                    if (!string.IsNullOrEmpty(model.Utype))
                    {

                        strwhere += " and  Utype = '" + model.Utype + "' ";
                    }
                }
                else
                {
                    strwhere += " where  Utype = '" + model.Utype + "' ";
                }

            }
            string sql = "select " + AM.Fields + " from tblmenber " + strwhere + " order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblmenber m = new tblmenber();
                m.UserNo = Convert.ToString(dr["UserNo"]);
                m.Uschool = Convert.ToString(dr["Uschool"]);
                m.ChineseName = Convert.ToString(dr["ChineseName"]);
                m.Uclass = Convert.ToString(dr["Uclass"]);
                m.Umobile = Convert.ToString(dr["Umobile"]);
                m.Uqq = Convert.ToString(dr["Uqq"]);
                m.Uaddtime = Convert.ToDateTime(dr["Uaddtime"]).ToString("yyyy-MM-dd");
                m.EditDateTime = Convert.ToDateTime(dr["EditDateTime"]).ToString("yyyy-MM-dd");
                m.Utype = Convert.ToString(dr["Utype"]);
                m.Uway = Convert.ToString(dr["Uway"]);
                m.Usex = Convert.ToString(dr["Usex"]);
                m.Valid = (Convert.ToString(dr["Valid"]) == "Y") ? "启用中" : "失效中";
                m.S_flag = Convert.ToString(dr["s_flag"]);
                if (!string.IsNullOrWhiteSpace(Convert.ToString(dr["SigninTime"])))
                {
                    if (DateTime.Compare(DateTime.Now.Date, Convert.ToDateTime(dr["SigninTime"]).Date) == 0)
                        m.SigninTime = Convert.ToString(dr["SigninTime"]);
                    else
                        m.SigninTime = string.Empty;
                }
                else
                    m.SigninTime = string.Empty;
                menbers.Add(m);
            }
            return menbers;
        }

        public List<tblmenber> GetNums(List<string> unos)
        {
            List<tblmenber> menbers = new List<tblmenber>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (unos != null && unos.Count > 0)
            {
                strwhere = " where userno in(" + string.Join(",", unos.ToArray()) + ") ";
            }
            else
            {
                return menbers;
            }
            string sql = "select " + AM.Fields + " from tblmenber " + strwhere + " order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            
            foreach (DataRow dr in dt.Select())
            {
                if (RexHelper.IsMatch(Convert.ToString(dr["Umobile"]).Trim(),RexHelper.rexType.Phone))
                {
                    tblmenber m = new tblmenber();
                    m.UserNo = Convert.ToString(dr["UserNo"]);
                    m.Uschool = Convert.ToString(dr["Uschool"]);
                    m.ChineseName = Convert.ToString(dr["ChineseName"]);
                    m.Uclass = Convert.ToString(dr["Uclass"]);
                    m.Umobile = Convert.ToString(dr["Umobile"]);
                    m.Uqq = Convert.ToString(dr["Uqq"]);
                    m.Uaddtime = Convert.ToDateTime(dr["Uaddtime"]).ToString("yyyy-MM-dd");
                    m.EditDateTime = Convert.ToDateTime(dr["EditDateTime"]).ToString("yyyy-MM-dd");
                    m.Utype = Convert.ToString(dr["Utype"]);
                    m.Uway = Convert.ToString(dr["Uway"]);
                    m.Usex = Convert.ToString(dr["Usex"]);
                    m.Valid = (Convert.ToString(dr["Valid"]) == "Y") ? "启用中" : "失效中";
                    m.S_flag = Convert.ToString(dr["s_flag"]);
                    if (!string.IsNullOrWhiteSpace(Convert.ToString(dr["SigninTime"])))
                    {
                        if (DateTime.Compare(DateTime.Now.Date, Convert.ToDateTime(dr["SigninTime"]).Date) == 0)
                            m.SigninTime = Convert.ToString(dr["SigninTime"]);
                        else
                            m.SigninTime = string.Empty;
                    }
                    else
                        m.SigninTime = string.Empty;
                    if (isExistMB(menbers,m.Umobile)==false)
                        menbers.Add(m);
                }
            }
            return menbers;
        }

        Func<List<tblmenber>,string, bool> isExistMB = (ms,mb) => {

            bool result = false;
            if (ms.Where(m => m.Umobile.Contains(mb)).SingleOrDefault() != null)
                result = true;

            return result;
        
        };

    }
}

