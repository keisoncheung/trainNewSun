using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class tblSMSList
    {
        /// <summary>
        /// title,content
        /// </summary>
        public string Fields = "title,content";
        public string title { get; set; }
        public string content { get; set; }
        public string createtime { get; set; }
        public string status { get; set; } 
    }
}
