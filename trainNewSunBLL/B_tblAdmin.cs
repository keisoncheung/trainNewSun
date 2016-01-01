using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblAdmin : BusinessBase
    {
        tblAdmin AM = new tblAdmin();
         
        public string GetMaxNo()
        {
            int intLen = 4;
            string FirstChar = "A";
            string no = "";
            string strSQL = "";
            try
            {
                strSQL = "select Max(UserNo) as MaxUserNo from tblAdmin";
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
            strSQL = "select top 1 UserNo from tblAdmin where LoginName='" + No + "'";
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

        public bool InsertModel(tblAdmin model)
        {
            bool result = false;
            string sql = "insert into tblAdmin(" + AM.Fields + ")values('" + model.UserNo + "','" + model.LoginName + "','" + model.ChineseName + "','" + model.Password + "','" + model.Valid + "','"+model.A_money+"','"+model.smsNums+"','"+model.smsContent+"')";
            if (OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null)!=-1)
                result=true; 
            return result;
        }

        public bool UpdateModel(tblAdmin model)
        {
            bool result = false;
            List<string> sbr=new List<string>();
            if (model != null)
            {
                if (!string.IsNullOrWhiteSpace(model.ChineseName)) sbr.Add(" ChineseName='" + model.ChineseName + "'");
                if (!string.IsNullOrWhiteSpace(model.Password)) sbr.Add(" [Password]='" + model.Password + "'");
                if (!string.IsNullOrWhiteSpace(model.A_money)) sbr.Add(" [A_money]='" + model.A_money + "'");
                if (!string.IsNullOrWhiteSpace(model.smsContent)) sbr.Add(" [smsContent]='" + model.smsContent + "'");
                if (!string.IsNullOrWhiteSpace(model.Acountpwd)) sbr.Add(" [Acountpwd]='" + model.Acountpwd + "'");
                if (!string.IsNullOrWhiteSpace(model.SigninCount)) sbr.Add(" [SigninCount]='" + model.SigninCount + "'");
                string sql = "update tblAdmin set " + string.Join(",",sbr.ToArray()) + " where LoginName='"+model.LoginName+"'";
                if (OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, sql, null) != -1)
                    result = true;
            }
            return result;
        }

        /// <summary>
        /// BY UserName
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public tblAdmin GetFullInfo(string Name)
        {
            tblAdmin _user = new tblAdmin();
            string strSQL = "select " + AM.Fields + " from tblAdmin  where LoginName='" + Name + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _user.UserNo = dt.Rows[0]["UserNo"].ToString();
                _user.LoginName = dt.Rows[0]["LoginName"].ToString();
                _user.ChineseName = dt.Rows[0]["ChineseName"].ToString();
                _user.Password = dt.Rows[0]["Password"].ToString();
                _user.Valid = dt.Rows[0]["Valid"].ToString();
                _user.A_money = dt.Rows[0]["A_money"].ToString();
                _user.smsNums = Convert.ToInt32(dt.Rows[0]["smsNums"]);
                _user.smsContent = Convert.ToString(dt.Rows[0]["smsContent"]);
            }
            else
            {
                _user = null;

            }
            return _user;
        }


        

        public bool UpdateSMSnums(int num,string name)
        {
            bool bol = false;
            tblAdmin _user = new tblAdmin();
            string strSQL = "update  tblAdmin  set smsNums=smsNums-" + num + "  where LoginName='" + name + "'";
            OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, strSQL, null);
            return bol;
        }
    }
}
