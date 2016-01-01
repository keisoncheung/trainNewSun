using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblAdmin
    {
        /// <summary>
        /// UserNo, LoginName, ChineseName, Password, Valid,A_money,smsNums,smsContent"
        /// </summary>
        public string Fields = "UserNo, LoginName, ChineseName, Password, Valid,A_money,smsNums,smsContent,Acountpwd,SigninCount";

        # region Props
        private string _UserNo;
        public string UserNo
        {
            get { return _UserNo; }
            set { _UserNo = value; }
        }

        private string _LoginName;
        public string LoginName
        {
            get { return _LoginName; }
            set { _LoginName = value; }
        }

        private string _ChineseName;
        public string ChineseName
        {
            get { return _ChineseName; }
            set { _ChineseName = value; }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _Valid;
        public string Valid
        {
            get { return _Valid; }
            set { _Valid = value; }
        }

        public string A_money { get; set; }

        public int smsNums { get; set; }

        public string smsContent { get; set; }

        public string Acountpwd { get; set; }

        public string SigninCount { get; set; }
        # endregion
    }
}
