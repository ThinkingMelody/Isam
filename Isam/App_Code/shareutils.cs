using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isam
{
    public class shareutils
    {


        public void BindByName(ref StringList pSTMT, string pDataType, string pField, object pValue)
        {
            string s1, s2, s3 = "";
            int len1, len2, offset;
            string sValue;

            //型別不同轉換成字串處理
            sValue = pValue.ToString();

            len1 = pSTMT.Count;
            len2 = pField.Length + 1;
            offset = pSTMT.ToString().IndexOf(":" + pField) + 1;

            if (offset == 0) return;

            s1 = pSTMT.ToString().Substring(0, offset);
            s2 = pSTMT.ToString().Substring(offset + len2);

            if (pDataType.ToUpper() == "I")
            {
                s3 = s1 + i2s(s2i(sValue)) + s2;
            }
            else if (pDataType.ToUpper() == "C")
            {
                s3 = s1 + sValue.ToString() + s2;
            }
            else if (pDataType.ToUpper() == "F")
            {
                s3 = s1 + (float.Parse(sValue)).ToString() + s2;
            }
            else if (pDataType.ToUpper() == "S")
            {
                s3 = s1 + "''" + sValue + "''" + s2;
            }
            pSTMT.Clear();
            pSTMT.AppendText(s3);
        }

        public string i2s(int v)
        {
            return v.ToString();
        }

        public string f2s(object v)
        {
            return v.ToString();
        }

        public string i2s(object v, int len)
        {
            string svalue;

            svalue = Math.Truncate((decimal)v).ToString();

            if (s2i(svalue) < 0)
            {
                return svalue.Substring(0, 1) + i2s(svalue.Substring(1), len - 1);
            }
            else
            {
                return pad_zero_h(svalue, len);
            }
        }


        public int s2i(string s)
        {
            string a = s.Trim();
            if (a == "+" || a == "-" || a.Trim() == "")
            {
                a = "0";
            }
            try
            {
                return int.Parse(a);
            }
            catch
            {
                return 0;
            }

        }

        public string pad_zero_h(string src, int len)
        {
            int i;

            i = len - src.Length;

            for (int j = 1; j < i; j++)
            {
                src = '0' + src;
            }
            if (i < 0)
            {
                return src.Substring(0, len);
            }
            else
            {
                return src;
            }
        }
    }
}
