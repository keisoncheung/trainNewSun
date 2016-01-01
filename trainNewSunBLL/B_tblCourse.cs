using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblCourse : BusinessBase
    {

        tblCourse AM = new tblCourse();

        public string GetMaxNo()
        {
            int intLen = 5;
            string FirstChar = "B";
            string no = "";
            string strSQL = "";
            try
            {
                strSQL = "select Max(courseNo) as MaxcourseNo from tblCourse";
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
                if (dt.Rows[0]["MaxcourseNo"].ToString() == "")
                {
                    no = FirstChar + "1".PadLeft(intLen - FirstChar.Length, '0');
                }
                else
                {
                    int intTmp = Convert.ToInt32(dt.Rows[0]["MaxcourseNo"].ToString().Substring(FirstChar.Length, intLen - FirstChar.Length));
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
            strSQL = "select top 1 courseNo from tblCourse where courseNo='" + No + "'";
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

        public bool InsertModel(tblCourse model)
        {
            bool result = false;
            string sql = "insert into tblCourse(" + AM.Fields + ")values('" + model.courseNo + "','" + model.courseName + "')";
            try
            {
                OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null);
                result = true;
            }
            catch (Exception ee)
            {

            }
            return result;
        }

        public bool UpdateModel(tblCourse model)
        {
            bool result = false;
            List<string> sbr = new List<string>();
            if (model != null)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(model.courseName))) sbr.Add(" courseName='" + model.courseName + "'");
                string sql = "update tblCourse set " + string.Join(",", sbr.ToArray()) + " where courseNo='" + model.courseNo + "'";
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
        /// BY UserNo
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public tblCourse GetFullInfo(string Name)
        {
            tblCourse _model = new tblCourse();
            string strSQL = "select " + AM.Fields + " from tblCourse  where courseNo='" + Name + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _model.courseNo = Convert.ToString(dt.Rows[0]["courseNo"]);
                _model.courseName = Convert.ToString(dt.Rows[0]["courseName"]);
            }
            else
            {
                _model = null;

            }
            return _model;
        }

        public List<tblCourse> GetModels(tblCourse model)
        {
            List<tblCourse> menbers = new List<tblCourse>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.courseName))
                {
                    where.Add(" courseName like '%" + model.courseName + "%' ");
                }
                if (where.Count > 0)
                    strwhere = " where " + string.Join("or", where.ToArray());
            }
            string sql = "select " + AM.Fields + " from tblCourse " + strwhere + " order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblCourse m = new tblCourse();
                m.courseNo = Convert.ToString(dr["courseNo"]);
                m.courseName = Convert.ToString(dr["courseName"]);
                menbers.Add(m);
            }
            return menbers;
        }


    }
}

