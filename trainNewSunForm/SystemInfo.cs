using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using PublicHelper;


namespace trainNewSun
{
    public static class SystemInfo
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strPW"></param>
        /// <returns></returns>
        public static string MD5(string strPW)
        {
            MD5 m = new MD5CryptoServiceProvider();
            byte[] s = m.ComputeHash(UnicodeEncoding.UTF8.GetBytes(strPW));
            string str = BitConverter.ToString(s);
            return str.Replace("-", "");

        }


        public static string LoginUser { get; set; }
        public static int SMSNums { get; set; }

        public static int getSMSNums()
        {
            string sql = "select smsnums from tblAdmin where LoginName='"+LoginUser+"'";
            return Convert.ToInt32(OleDbHelper.ExecuteScalar(OleDbHelper.Conn, sql, null));
        }

        public static void Log(string MsgType, string Msg)
        {
            string strSQL = "";
            strSQL = "insert into tblMsg(MsgType, Msg,  opuser) values('" + MsgType + "','" + Msg + "','" + LoginUser + "');";
            OleDbHelper.ExecuteNonQuery(OleDbHelper.Conn, strSQL, null);
        }

        public static string SofeName { get{return "新太阳培训管理系统";}}
        public static string Version { get { return "V 1.2.1"; } }
        public static string Author { get {return "张启新";}}
        public static string QQ { get { return "372707575"; } }
        public static string AuthorEmail { get { return "accpzyyx@126.com "; } }



        /// <summary>
        /// 日志类别
        /// </summary>
        public static class MsgType
        {
            public enum Type
            {
                /// <summary>
                /// 管理员
                /// </summary>
                ADM, 
                /// <summary>
                /// 用户
                /// </summary>
                USR,
                /// <summary>
                /// 学员
                /// </summary>
                TRA,
                /// <summary>
                /// 教师
                /// </summary>
                TEH,
                /// <summary>
                /// 课程
                /// </summary>
                COU
            }
        }
    }
}
