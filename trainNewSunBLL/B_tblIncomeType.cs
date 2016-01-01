using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PublicHelper;


namespace trainNewSun
{
    public class B_tblIncomeType
    {
        tblIncomeType AM = new tblIncomeType();


        /// <summary>
        /// BY UserNo
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public tblIncomeType GetFullInfo(string Name)
        {
            tblIncomeType _model = new tblIncomeType();
            string strSQL = "select " + AM.Fields + " from tblIncomeType  where IncomeNo='" + Name + "'";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, strSQL, null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                _model.IncomeNo = Convert.ToString(dt.Rows[0]["IncomeNo"]);
                _model.IncomeName = Convert.ToString(dt.Rows[0]["IncomeName"]);
                _model.IType = Convert.ToString(dt.Rows[0]["IType"]);
            }
            else
            {
                _model = null;

            }
            return _model;
        }

        public List<tblIncomeType> GetModels(tblIncomeType model)
        {
            List<tblIncomeType> menbers = new List<tblIncomeType>();
            List<string> where = new List<string>();
            string strwhere = "";
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.IncomeName))
                {
                    where.Add(" IncomeName like '%" + model.IncomeName + "%' ");
                }
                if (!string.IsNullOrEmpty(model.IType))
                {
                    where.Add(" IType like '%" + model.IType + "%' ");
                }
                if (where.Count > 0)
                    strwhere = " where " + string.Join("or", where.ToArray());
            }
            string sql = "select " + AM.Fields + " from tblIncomeType " + strwhere + "";
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                tblIncomeType m = new tblIncomeType();
                m.IncomeNo = Convert.ToString(dr["IncomeNo"]);
                m.IncomeName = Convert.ToString(dr["IncomeName"]);
                m.IType = Convert.ToString(dr["IType"]);
                menbers.Add(m);
            }
            return menbers;
        }
    }
}
