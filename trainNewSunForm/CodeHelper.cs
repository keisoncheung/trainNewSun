using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace trainNewSun
{
    public static class CodeHelper
    {
        public enum rexType
        {
            /// <summary>
            /// 手机号码
            /// </summary>
            Phone,
            /// <summary>
            /// 电话号码
            /// </summary>
            Tel,
            /// <summary>
            /// 电子邮箱
            /// </summary>
            Email,

        }


        public static Func<string, rexType, bool> RexMath = (str,rex) => {
            return Regex.IsMatch(str, GetPattern(rex));
        };

        public static Func<rexType, string> GetPattern = g =>
        {
            string pattern = string.Empty;
            switch (g)
            {
                case rexType.Phone:
                    pattern = @"(^(01|1)[3,4,5,8][0-9])\d{8}$";
                    break;
                default:
                    pattern = @"(^(01|1)[3,4,5,8][0-9])\d{8}$";
                    break;
            }
            return pattern;
        };
    }
}
