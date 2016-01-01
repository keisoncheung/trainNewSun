using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblIncome : BusinessBase
    {
        tblIncome AM = new tblIncome();

        public string GetMaxNo()
        {
            int intLen = 9;
            string FirstChar = "I";
            string no = "";
            string strSQL = "";
            try
            {
                strSQL = "select Max(iNo) as MaxiNo from tblIncome";
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
                if (dt.Rows[0]["MaxiNo"].ToString() == "")
                {
                    no = FirstChar + "1".PadLeft(intLen - FirstChar.Length, '0');
                }
                else
                {
                    int intTmp = Convert.ToInt32(dt.Rows[0]["MaxiNo"].ToString().Substring(FirstChar.Length, intLen - FirstChar.Length));
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
            strSQL = "select top 1 iNo from tblIncome where iNo='" + No + "'";
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

        public bool InsertModel(tblIncome model)
        {
            bool result = false;
            string sql = "insert into tblIncome(" + AM.Fields + ")values('" + model.iNo + "','" + model.itest + "','" + model.amounts + "','" + model.itype + "','" + model.createDateTime + "','" + model.imenber + "','" + model.icometype + "')";
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

        public bool UpdateModel(tblIncome model)
        {
            bool result = false;
            List<string> sbr = new List<string>();
            if (model != null)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(model.itype))) sbr.Add(" itype='" + model.itype + "'");
                if (!string.IsNullOrWhiteSpace(model.iNo)) sbr.Add(" iNo='" + model.iNo + "'");
                if (!string.IsNullOrWhiteSpace(model.itest)) sbr.Add(" itest='" + model.itest + "'");
                if (!string.IsNullOrWhiteSpace(model.imenber)) sbr.Add(" imenber='" + model.imenber + "'");
                if (!string.IsNullOrWhiteSpace(model.icometype)) sbr.Add(" icometype='" + model.icometype + "'");
                string sql = "update tblIncome set " + string.Join(",", sbr.ToArray()) + " where iNo='" + model.iNo + "'";
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
        public tblIncome GetFullInfo(string Name)
        {
            tblIncome _incone = new tblIncome();
            string strSQL = "select " + AM.Fields + " from tblIncome  where iNo='" + Name + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _incone.iNo = Convert.ToString(dt.Rows[0]["iNo"]);
                _incone.itest = Convert.ToString(dt.Rows[0]["itest"]);
                _incone.itype = Convert.ToString(dt.Rows[0]["itype"]);
                _incone.createDateTime = Convert.ToString(dt.Rows[0]["createDateTime"]);
            }
            else
            {
                _incone = null;

            }
            return _incone;
        }

        public List<tblIncome> GetModels(tblIncome model)
        {
            List<tblIncome> menbers = new List<tblIncome>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.iNo))
                {
                    where.Add(" iNo like '%" + model.iNo + "%' ");
                }

                if (!string.IsNullOrEmpty(model.itype))
                {
                    where.Add(" itype like '%" + model.itype + "%' ");
                }
                if (!string.IsNullOrEmpty(model.itest))
                {
                    where.Add(" itest like '%" + model.itest + "%' ");
                }
                if (model.dateStart != null && model.dateEnd != null)
                {
                    where.Add(" createDateTime between #"+model.dateStart+"# and #"+model.dateEnd+"#");
                }

                if (where.Count > 0)
                    strwhere = " where " + string.Join("or", where.ToArray());
            }
            string sql = "select " + AM.Fields + " from tblIncome " + strwhere + " order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblIncome m = new tblIncome();
                m.iNo = Convert.ToString(dr["iNo"]);
                m.itest = Convert.ToString(dr["itest"]);
                m.itype = Convert.ToString(dr["itype"]);
                m.amounts = Convert.ToString(dr["amounts"]);
                m.createDateTime = Convert.ToString(dr["createDateTime"]);
                menbers.Add(m);
            }
            return menbers;
        }


        public List<tblIncome> GetModels2(tblIncome model)
        {
            List<tblIncome> menbers = new List<tblIncome>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.iNo))
                {
                    where.Add(" iNo like '%" + model.iNo + "%' ");
                }

                if (!string.IsNullOrEmpty(model.itype))
                {
                    where.Add(" itype like '%" + model.itype + "%' ");
                }
                if (!string.IsNullOrEmpty(model.itest))
                {
                    where.Add(" itest like '%" + model.itest + "%' ");
                }
                if (model.dateStart != null && model.dateEnd != null)
                {
                    where.Add(" createDateTime between #" + model.dateStart + "# and #" + model.dateEnd + "#");
                }

                if (where.Count > 0)
                    strwhere = " where " + string.Join("and", where.ToArray());
            }
            string sql = "select " + AM.Fields + " from tblIncome " + strwhere + " order by id desc";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblIncome m = new tblIncome();
                m.iNo = Convert.ToString(dr["iNo"]);
                m.itest = Convert.ToString(dr["itest"]);
                m.itype = Convert.ToString(dr["itype"]);
                m.icometype = Convert.ToString(dr["icometype"]);
                m.imenber = Convert.ToString(dr["imenber"]);
                m.amounts = Convert.ToString(dr["amounts"]);
                m.createDateTime = Convert.ToDateTime(dr["createDateTime"]).ToString("yyyy-MM-dd");
                menbers.Add(m);
            }
            return menbers;
        }

        public decimal getAmounts(string DS, string DE,string itype)
        {
            decimal _out = 0;
            decimal _in = 0;
            DataTable dt = new DataTable();
            string sql = "";
            string where = "";
            if (itype == "")
            {
                sql = " select SUM(amounts)as amounts from tblIncome where itype='O'";
                dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
                if (dt.Rows.Count > 0)
                    if (!string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0][0])))
                        _out = Convert.ToDecimal(Convert.ToString(dt.Rows[0][0]));
                sql = " select SUM(amounts)as amounts from tblIncome where itype='I'";
                dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
                if (!string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0][0])))
                    _in = Convert.ToDecimal(Convert.ToString(dt.Rows[0][0]));
                return Math.Round(Convert.ToDecimal(_in - _out), 2);
            }
            else
            {
                if (DS != "" && DE != "")
                    where = "  AND createDateTime between #" + DS + "# and #" + DE + "#   ";
                sql = " select SUM(amounts)as amounts from tblIncome  WHERE itype='" + itype + "' " + where + "";
                dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
                if (dt.Rows.Count > 0)
                    if (!string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0][0])))
                        _out = Convert.ToDecimal(Convert.ToString(dt.Rows[0][0]));
                
            }
            return _out;
        }

        public decimal getAmountsF(string DS, string DE)
        {
            decimal _out = 0;
            string sql = " select SUM(amount)as amount from tblHaveClass_Detail where Format(startTime, 'yyyy-mm-dd')  between #" + DS + "# and #" + DE + "# and ctype='O'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count > 0)
                if (!string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0][0])))
                    _out = Convert.ToDecimal(Convert.ToString(dt.Rows[0][0]));
            return Math.Round(_out, 2);
        }

        public decimal getAmountsS(string DS, string DE)
        {
            decimal _in = 0;
            string sql = " select SUM(amount)as amount from tblHaveClass_Detail where Format(startTime, 'yyyy-MM-dd')  between #" + DS + "# and  #" + DE + "# and ctype='I'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count > 0)
                if (!string.IsNullOrWhiteSpace(Convert.ToString(dt.Rows[0][0])))
                    _in = Convert.ToDecimal(Convert.ToString(dt.Rows[0][0]));
            return Math.Round(_in, 2);
        }


        public bool ifContinue(string name,string pwd)
        {
            bool result = false;
            string sql = "select Acountpwd from tblAdmin where LoginName='" + name + "'";
            DataTable dt=OleDbHelper.ExecuteDataSet(OleDbHelper.Conn,sql,null).Tables[0];
            foreach(DataRow dr in dt.Rows)
            {
                if (pwd == Convert.ToString(dr[0]))
                    result = true;
            }
            return result;
        }


    }
}

