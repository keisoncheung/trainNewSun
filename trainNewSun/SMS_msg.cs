using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainNewSun
{
    public class SMS_msg
    {
        private string _uid;
        public string uid { get { return _uid; } set { _uid=value;} }
        public string pwd { get; set; }
        public List<string> phones { get; set; }
        public string content { get; set; }
        public string bid { get; set; }
    }

}
