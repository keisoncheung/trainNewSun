using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Web;
using System.Net.Mail;

namespace trainNewSun
{
    public class B_SMS
    {
        //Encoding encoding = Encoding.GetEncoding("gb2312");
        //public bool ToMobile(SMS_msg sms)
        //{//移动的接口
        //    bool result = false;
        //    string strRet = "";
        //    List<SMS> ListSMS = new List<SMS>();
        //    try
        //    {
        //        string accountid = "lzx";
        //        string pwd = "lzx123456";
                
        //        //string accountid = "gzdq";
        //        //string pwd = "gzdq123456";
        //        //string postData = "";
        //        string postData = "zh=" + HttpUtility.UrlEncode(accountid, encoding) + "&mm=" + HttpUtility.UrlEncode(pwd, encoding) + "&hm=" + HttpUtility.UrlEncode(string.Join(",", sms.phones.ToArray()), encoding) + "&nr=" + HttpUtility.UrlEncode(sms.content, encoding) + "&dxlbid=" + HttpUtility.UrlEncode("39", encoding) + "";
        //        string strUrl = "http://www.6610086.cn/smsComputer/smsComputersend.asp?" + postData;

        //        byte[] data = encoding.GetBytes(postData);
        //        // 准备请求... 
        //        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(strUrl);
        //        myRequest.Method = "Get";
        //        //myRequest.ContentType = "application/x-www-form-urlencoded";
        //        //myRequest.ContentLength = data.Length;

        //        WebResponse hs = myRequest.GetResponse();
        //        Stream sr = hs.GetResponseStream();
        //        StreamReader ser = new StreamReader(sr, Encoding.Default);
        //        strRet = ser.ReadToEnd();
        //        if (strRet == "0")
        //        {
        //            result = true;
        //        }
        //        hs.Close();
        //        ser.Dispose();
                

        //        //Stream newStream = myRequest.GetRequestStream();
        //        //// 发送数据 
        //        //newStream.Write(data, 0, data.Length);
        //        //newStream.Close();
        //        Thread.Sleep(3000);
        //     }
        //    catch (Exception e)
        //    {

        //        strRet = null;
        //        result = false;
        //    }
        //    return result;

        //}


        Encoding encoding = Encoding.GetEncoding("UTF-8");
        public bool ToMobile(SMS_msg sms)
        {
            //移动的接口
            bool result = false;
            string strRet = "";
            List<SMS> ListSMS = new List<SMS>();
            try
            {
                string accountid = "sms_gzd7";
                string pwd = "aspnet";
                string postData = "";
                foreach (string str in sms.phones)
                {
                    //string accountid = "gzdq";
                    //string pwd = "gzdq123456";
                    //string postData = "";
                    //string postData = "zh=" + HttpUtility.UrlEncode(accountid, encoding) + "&mm=" + HttpUtility.UrlEncode(pwd, encoding) + "&hm=" + HttpUtility.UrlEncode(string.Join(",", sms.phones.ToArray()), encoding) + "&nr=" + HttpUtility.UrlEncode(sms.content, encoding) + "&dxlbid=" + HttpUtility.UrlEncode("39", encoding) + "";
                    postData = "Action=SendMessage&UserId=" + accountid + "&UserPwd=" + pwd + "&SendPhone=" + str + "&SendMessage=" + sms.content + "【新太阳信使】&SendPort=4";
                    string strUrl = "http://86api.com/sms/SmsHttpPort.aspx?" + postData;

                    byte[] data = encoding.GetBytes(postData);
                    // 准备请求... 
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(strUrl);
                    myRequest.Method = "Get";
                    //myRequest.ContentType = "application/x-www-form-urlencoded";
                    //myRequest.ContentLength = data.Length;

                    WebResponse hs = myRequest.GetResponse();
                    Stream sr = hs.GetResponseStream();
                    StreamReader ser = new StreamReader(sr, Encoding.Default);
                    strRet = ser.ReadToEnd();
                    if (strRet == "0")
                    {
                        result = true;
                    }
                    hs.Close();
                    ser.Dispose();

                    //Stream newStream = myRequest.GetRequestStream();
                    //// 发送数据 
                    //newStream.Write(data, 0, data.Length);
                    //newStream.Close();
                    Thread.Sleep(200);
                }
                
            }
            catch (Exception e)
            {
                strRet = null;
                result = false;
            }


            int nums = CountNums(sms.content) * sms.phones.Count;
            new B_tblAdmin().UpdateSMSnums(nums, "LZX");
            //if (nums >=50)
            //    sendmail("czflysw@163.com", "LZX短信群发通知", "发送条数：" + nums + "；剩余条数:" + new B_tblAdmin().GetFullInfo("LZX").smsNums + "");
            return result;
        }


        /// <summary>
        /// 短信60个数字一个数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountNums(string str)
        {
            int num = 1;
            if (str.Length > 60)
            {
                num = str.Length / 60;
                if (str.Length > (60 * num))
                    num += 1;
            }
            return num;
        }


        　public　int　sendmail(string　to,　string　body,string　subject) 
　　　　{ 
　　　　　　　　try 
　　　　　　　　{ 
　　　　　　　　　　　　int　nContain　=　0; 
　　　　　　　　　　　　///添加发件人地址 
　　　　　　　　　　　　string　from　=　"czflysw@163.com"; 
　　　　　　　　　　　　MailMessage　mailMsg　=　new　MailMessage(); 
　　　　　　　　　　　　mailMsg.From　=　new　MailAddress(from); 
　　　　　　　　　　　　nContain　+=　mailMsg.From.Address.Length; 
　　　　　　　　　　　　///添加收件人地址 
　　　　　　　　　　　　mailMsg.To.Add(to); 
　　　　　　　　　　　　nContain　+=　mailMsg.To.ToString().Length; 
　　　　　　　　　　　　///添加邮件主题 
　　　　　　　　　　　　mailMsg.Subject　=　subject; 
　　　　　　　　　　　　mailMsg.SubjectEncoding　=　Encoding.UTF8; 
　　　　　　　　　　　　nContain　+=　mailMsg.Subject.Length; 
　　　　　　　　　　　　///添加邮件内容 
　　　　　　　　　　　　mailMsg.Body　=　body; 
　　　　　　　　　　　　mailMsg.BodyEncoding　=　Encoding.UTF8; 
　　　　　　　　　　　　mailMsg.IsBodyHtml　=　true; 
　　　　　　　　　　　　nContain　+=　mailMsg.Body.Length; 
　　　　　　　　　　　　if　(mailMsg.IsBodyHtml　==　true) 
　　　　　　　　　　　　{ 
　　　　　　　　　　　　　　　　nContain　+=　100; 
　　　　　　　　　　　　} 
　　　　　　　　　　　　///发送邮件 
　　　　　　　　　　　　try 
　　　　　　　　　　　　{ 
　　　　　　　　　　　　　　　　//定义发送邮件的Client 
　　　　　　　　　　　　　　　　SmtpClient　client　=　new　SmtpClient(); 
　　　　　　　　　　　　　　　　//表示以当前登录用户的默认凭据进行身份验证　 
                
               
                client.EnableSsl = false; 
　　　　　　　　　　　　　　　　//包含用户名和密码　 
　　　　　　　　　　　　　　　　client.Credentials　=　new　System.Net.NetworkCredential("czflysw@163.com","850222"); 
　　　　　　　　　　　　　　　　///设置邮件服务器主机的IP地址 
                client.Host = "smtp.163.com";
　　　　　　　　　　　　　　　　///设置邮件服务器的端口 
　　　　　　　　　　　　　　　　//client.Port　=　25; 
　　　　　　　　　　　　　　　　///配置发送邮件的属性 
　　　　　　　　　　　　　　　　client.DeliveryMethod　=　SmtpDeliveryMethod.Network; 
　　　　　　　　　　　　　　　　//System.Net.Mail.MailMessage　message　=　new　System.Net.Mail.MailMessage(strFrom,　strto,　strSubject,　strBody);　 
　　　　　　　　　　　　　　　　mailMsg.Priority　=　System.Net.Mail.MailPriority.Normal;
                client.UseDefaultCredentials = true; 
　　　　　　　　　　　　　　　　///发送邮件 
　　　　　　　　　　　　　　　　client.Send(mailMsg); 
　　　　　　　　　　　　　　　　return　1; 
　　　　　　　　　　　　} 
　　　　　　　　　　　　catch　(Exception　ex)　{　return　0;　} 
　　　　　　　　} 
　　　　　　　　catch　(Exception　ex)　{　return　0;　} 
　　　　}


        
       
    }




    public class SMS
    {
        public List<string> successSMS { get; set; }
        public List<string> ErrorSMS { get; set; }
    }


  


}
