using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReadTextFileProduct.Actions
{
    public class CheckNameConsumerAction
    {
        public bool CheckNameConsumer(string line)
        {
            string s = line.Trim();

            bool result = false;

            //int check = 0;

            string[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.None);

            //foreach(string part in parts)
            //{

            //    string pattern = @"^(\p{L}+\s?)+$";

            //    Regex reg = new Regex(pattern);

            //    if (reg.IsMatch(part))
            //    {
            //        check++;
            //    }
            //    else
            //    {
            //        check --;
            //        break;
            //    }
            //}

            //if(check == parts.Length)
            //{
            //    result = true;
            //}

            if(parts.Length >= 1)
            {
                string pattern = @"^(\p{L}+\s?)+$";

                Regex reg = new Regex(pattern);
                if(reg.IsMatch(parts[0]))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
