using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblHaveClass : BusinessBase
    {

        tblCourse AM = new tblCourse();
        tblHaveClass_Header hch = new tblHaveClass_Header();
        tblHaveClass_Detail hcd = new tblHaveClass_Detail();
        tblPayMoney pm = new tblPayMoney();
        tblmenber mem = new tblmenber();
        tblIncome im = new tblIncome();
        B_tblIncome bim = new B_tblIncome();
        B_tblmenber bmem = new B_tblmenber();
        B_tblCourse BAM = new B_tblCourse();
        public string GetMaxNo()
        {
            int intLen = 8;
            string FirstChar = "HC";
            string no = "";
            string strSQL = "";
            try
            {
                strSQL = "select Max(cid) as Maxcid from tblHaveClass_Header";
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
                if (dt.Rows[0]["Maxcid"].ToString() == "")
                {
                    no = FirstChar + "1".PadLeft(intLen - FirstChar.Length, '0');
                }
                else
                {
                    int intTmp = Convert.ToInt32(dt.Rows[0]["Maxcid"].ToString().Substring(FirstChar.Length, intLen - FirstChar.Length));
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



        public bool isExistModel(string strcour, string strmem)
        {
            string strSQL = "";
            strSQL = "select top 1 cid from tblHaveClass_Header where courseNo='" + strcour + "' and userNO='" + strmem + "'";
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

        public bool InsertModel(tblHaveClass_Header model)
        {
            bool result = false;
            string sql = "";
            try
            {
               

                if (isExistModel(model.Course.courseNo,model.menber.UserNo) == false)
                {
                    sql="insert into tblHaveClass_Header(" + hch.Fields + ")values('" + model.cid + "','" + model.menber.UserNo + "','" +model.Course.courseNo+"');";
                    OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                }
                if (model.HaveClass_Detail != null)
                {
                    sql="delete * from tblHaveClass_Detail where cid='" + model.cid + "'";
                    OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                    foreach(tblHaveClass_Detail detail in model.HaveClass_Detail)
                    {
                       
                        sql="insert into tblHaveClass_Detail("+hcd.Fields+")values('"+detail.cid+"',"+detail.classNum+","+detail.personCount+",'"+detail.startTime+"',"+detail.amount+",'"+detail.isFinish+"','"+detail.ctype+"');";
                        OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                    }  
                }
                result = true;
            }
            catch (Exception ee)
            {

            }
            return result;
        }


        public bool UpdateModel(tblHaveClass_Header model)
        {
            bool result = false;
            string sql = "";
            try
            {
                if (isExistModel(model.Course.courseNo, model.menber.UserNo) == true)
                {

                    if (model.HaveClass_Detail != null)
                    {
                        foreach (tblHaveClass_Detail detail in model.HaveClass_Detail)
                        {
                            sql = "update tblHaveClass_Detail set isFinish='Y' where cid='" + detail.cid + "' and classNum="+detail.classNum+"";
                            OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                        }
                    }
                    result = true;
                }
            }
            catch (Exception ee)
            {

            }
            return result;
        }

        public string GetCid(string strmem, string strcour)
        {
            string result = "";
            string strSQL = "select top 1 cid from tblHaveClass_Header where userNO='" + strcour + "' and courseNo='" + strmem + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
                result=Convert.ToString(dt.Rows[0]["cid"]);

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool PayMoney(tblHaveClass_Header model)
        {
            bool result = false;
            if (model!= null)
            {
                string sql = "insert into tblPayMoney(" + pm.Fields + ")values('" + model.courseNo + "','" + model.userNO + "','" + Math.Round(model.pMoney,2) + "','" + model.endDateTime + "','"+model.cid+"','"+model.ptype+"');";
                try
                {
                    OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                    if (insertIncome(model)==true)
                        result = true;
                }
                catch (Exception ee)
                {

                }
            }
            return result;
        }

        public bool insertIncome(tblHaveClass_Header model)
        {
            bool result = false;
            tblmenber men = bmem.GetFullInfo(model.userNO);
            tblCourse cou = BAM.GetFullInfo(model.courseNo);
            if (men != null && cou != null)
            {
                string sql = "insert into tblIncome(" + im.Fields + ")values('" + bim.GetMaxNo() + "','" + men.ChineseName + " " + cou.courseName + "','" + model.pMoney + "','" + model.ptype + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + men.ChineseName + "','" + cou.courseName + "')";
                OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                result = true;
            }
            return result;

             
        }



        /// <summary>
        /// BY UserNo
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public tblHaveClass_Header GetFullInfo(string strmem, string strcour)
        {
            tblHaveClass_Header _model = new tblHaveClass_Header();
            string sql = "select a.cid,a.userNO,a.courseNo,b.classNum,b.personCount,b.startTime,b.amount,b.isFinish,ctype from tblHaveClass_Header a left join tblHaveClass_Detail b on a.cid=b.cid where a.userNO='" + strmem + "'  and a.courseNo='" + strcour + "'  and b.isfinish='N' ";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _model.cid = Convert.ToString(dt.Rows[0]["cid"]);
                _model.courseNo = Convert.ToString(dt.Rows[0]["courseNo"]);
                _model.userNO = Convert.ToString(dt.Rows[0]["userNO"]);
                tblCourse c = new tblCourse();
                c.courseNo = Convert.ToString(dt.Rows[0]["courseNo"]);
                _model.Course = c;
                tblmenber m = new tblmenber();
                m.UserNo = Convert.ToString(dt.Rows[0]["userNO"]);
                _model.menber = m;

                List<tblHaveClass_Detail> details = new List<tblHaveClass_Detail>();
                foreach (DataRow dr in dt.Select())
                {
                    if (!string.IsNullOrWhiteSpace(Convert.ToString(dr["startTime"])))
                    {
                        tblHaveClass_Detail detail = new tblHaveClass_Detail();
                        detail.cid = Convert.ToString(dr["cid"]);
                        detail.amount = Convert.ToString(dr["amount"]);
                        detail.classNum = Convert.ToString(dr["classNum"]);
                        detail.personCount = Convert.ToString(dr["personCount"]);
                        detail.startTime = Convert.ToDateTime(dr["startTime"]).ToString("yyyy-MM-dd");
                        detail.isFinish = Convert.ToString(dr["isFinish"]);
                        detail.ctype = Convert.ToString(dr["ctype"]);
                        details.Add(detail);
                    }
                }
                _model.HaveClass_Detail = details;
            }
            else
            {
                _model = null;

            }
            return _model;
        }


        /// <summary>
        /// BY UserNo
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public List<tblHaveClass_Header> GetModels(tblHaveClass_Header _mod)
        {
            List<tblHaveClass_Header> _models = new List<tblHaveClass_Header>();
            
            StringBuilder sbr = new StringBuilder();
            if (_mod != null)
            {
                if (_mod.startDateTime != null && _mod.endDateTime2 != null)
                    sbr.Append(" AND  b.startTime between #" + _mod.startDateTime + "# and #" + _mod.endDateTime2 + "#");
                if (_mod.ctype != null)
                    sbr.Append(" and b.ctype='"+_mod.ctype+"'");
            }
            string sql = "select a.cid,a.userNO,a.courseNo,b.classNum,b.personCount,b.startTime,b.amount,b.isFinish,b.ctype from tblHaveClass_Header a left join tblHaveClass_Detail b on a.cid=b.cid  where b.isfinish='N' "+sbr.ToString()+"  order by b.starttime ";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                
                foreach (DataRow dr in dt.Select())
                {

                    if (!string.IsNullOrWhiteSpace(Convert.ToString(dr["startTime"])))
                    {
                        tblHaveClass_Header _model = new tblHaveClass_Header();
                        _model.cid = Convert.ToString(dr["cid"]);
                        _model.courseNo = Convert.ToString(dr["courseNo"]);
                        _model.userNO = Convert.ToString(dr["userNO"]);
                        tblCourse c = BAM.GetFullInfo(Convert.ToString(dr["courseNo"])); ;
                        _model.Course = c;
                        tblmenber m = bmem.GetFullInfo(Convert.ToString(dr["userNO"]));
                        _model.menber = m;

                        List<tblHaveClass_Detail> details = new List<tblHaveClass_Detail>();
                        tblHaveClass_Detail detail = new tblHaveClass_Detail();
                        detail.cid = Convert.ToString(dr["cid"]);
                        detail.amount = Convert.ToString(dr["amount"]);
                        detail.classNum = Convert.ToString(dr["classNum"]);
                        detail.personCount = Convert.ToString(dr["personCount"]);
                        detail.startTime = Convert.ToDateTime(dr["startTime"]).ToString("yyyy-MM-dd");
                        detail.isFinish = Convert.ToString(dr["isFinish"]);
                        detail.ctype = Convert.ToString(dr["ctype"]);
                        details.Add(detail);
                        _model.HaveClass_Detail = details;
                        _models.Add(_model);
                    }
                }
                
            }
            return _models;
        }


        public decimal getPayMoney(string cour, string men)
        {
            decimal result = 0;
            string sql = "select sum(amounts) as amounts from tblPayMoney where courseNo='" + cour + "' and userNO='" + men + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                result = Math.Round(Convert.ToDecimal((string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0]["amounts"])))?"0":Convert.ToString(dt.Rows[0]["amounts"])),2);
            }
            return result;
        }


        //public List<tblCourse> GetModels(tblCourse model)
        //{
        //    List<tblCourse> menbers = new List<tblCourse>();
        //    List<string> where = new List<string>();
        //    string strwhere = "";
        //    if (model != null)
        //    {
        //        if (!string.IsNullOrEmpty(model.courseName))
        //        {
        //            where.Add(" courseName like '%" + model.courseName + "%' ");
        //        }
        //        if (where.Count > 0)
        //            strwhere = " where " + string.Join("or", where.ToArray());
        //    }
        //    string sql = "select " + AM.Fields + " from tblCourse " + strwhere + " order by id desc";
        //    DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        //    foreach (DataRow dr in dt.Select())
        //    {
        //        tblCourse m = new tblCourse();
        //        m.courseNo = Convert.ToString(dr["courseNo"]);
        //        m.courseName = Convert.ToString(dr["courseName"]);
        //        menbers.Add(m);
        //    }
        //    return menbers;
        //}


    }
}

