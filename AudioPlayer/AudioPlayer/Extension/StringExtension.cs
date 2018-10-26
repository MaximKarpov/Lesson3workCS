using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer.Extension
{
   public static class StringExtension
    {
        public static string Cut(this string str, int count = 10, string postfix = "...")
        {

          

            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;

            }
            if (str.Length <= count)
            {
                return str;
            }

            char[] strinArr = new char[count + postfix.Length];

            for(int i = 0; i < count; i++)
            {
                strinArr[i] = str[i];
            }
            for(int i = count; i < count+postfix.Length; i++)
            {
                strinArr[i] = postfix[i - count];
                
            }
            return strinArr.ToString();
        }
    }
}
