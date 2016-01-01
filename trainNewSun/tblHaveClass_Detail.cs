using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblHaveClass_Detail
    { 
        public string Fields = "cid,classNum,personCount,startTime,amount,isFinish,ctype";
        public string cid { get; set; }
        public string classNum { get; set; } 
        public string personCount { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string amount { get; set; }
        public string ctype { get; set; }
        public string isFinish { get; set; }
    }
}
