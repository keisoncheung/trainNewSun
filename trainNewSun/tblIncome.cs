using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblIncome
    {
        public string Fields = "iNo,itest,amounts,itype,createDateTime,imenber,icometype";

        # region Props
        public string iNo { get; set; }
        public string itest { get; set; }
        public string imenber { get; set; } 
        public string amounts { get; set; }
        public string itype { get; set; }
        public string icometype { get; set; }
        public string createDateTime { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        #endregion
    }
} 
