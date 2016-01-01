using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblHaveClass_Header
    {
        public string Fields = "cid,userNO,courseNo";
        public string cid { get; set; }
        public string userNO { get; set; }
        public string courseNo { get; set; }
        public DateTime startDateTime { get; set; }
        public string ctype { get; set; }
        public string endDateTime { get; set; }
        public DateTime endDateTime2 { get; set; }
        public decimal pMoney { get; set; }
        public string ptype { get; set; }
        public List<tblHaveClass_Detail> HaveClass_Detail { get; set; }
        public tblCourse Course { get; set; } 
        public tblmenber menber { get; set; }
    } 
}
