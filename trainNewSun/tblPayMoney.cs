using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblPayMoney
    {
        public string Fields = "CourseNo,userNO,amounts,createDateTime,conTent,ptype";
        public string CourseNo { get; set; }
        public string userNO { get; set; }
        public string amounts { get; set; } 
        public string createDateTime { get; set; }
        public string conTent { get; set; }
        public string ptype { get; set; }
    }
}
