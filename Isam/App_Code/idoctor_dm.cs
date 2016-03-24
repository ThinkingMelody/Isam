using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isam.App_Code
{
    public class idoctor_dm
    {
        readonly string WHERE15= "EQUAL :DOCTOR_NO ";
        readonly string WHERE17 = "GTEQ :DOCTOR_NO ";
        readonly string WHERE18 = "GTEQ :DOCTOR_NO ";
        readonly string WHERE27 = "GTEQ :ID_NO ";
        readonly string WHERE28 = "GTEQ :ID_NO ";
        readonly string WHERE37 = "GTEQ :DOCTOR_NAME ";
        readonly string WHERE47 = "GTEQ :DIV_NO, :DOCTOR_NO ";
        readonly string WHERE48 = "GTEQ :DIV_NO, :DOCTOR_NO ";
        readonly string MAIN_KEY = "ID_DOCTOR_NO";

        IDOCTOR_REC idoctor_rec = new IDOCTOR_REC();
        StringList RunSql = new StringList();
        string CommStr, ResultStr;
        
        public idoctor_dm()
        {

        }

        public void check_fields(ref IDOCTOR_REC a, string orig_fields, bool check_only)
        {
            int i, j;
            bool error = false;
            //string error_msg = "";
            string field = "";

            if (!String.IsNullOrEmpty(orig_fields) && orig_fields != "*")
            {
                orig_fields = delete_space(orig_fields + ",");
                i = orig_fields.IndexOf(",");
                while (i != -1 && !error)
                {
                    field = orig_fields.Substring(0, i + 1);
                    j = check_col_name(ref a, field);

                    error = j == 0 ? true : false;

                    if (!error)
                        if (!check_only)
                            a.COL_CHECKED[j] = true;

                    orig_fields = orig_fields.Substring(i);
                    i = orig_fields.IndexOf(",");
                }
            }
            if (error)
            {
                throw new Exception("提示：IDOCTOR.SF：" + field + "  no such column.");
            }
        }

        public int check_col_name(ref IDOCTOR_REC a, string field)
        {
            int colIndex = 0;
            for (int i = 0; i < a.COLS - 1; i++)
            {
                if (a.COL_NAME[i] == field)
                {
                    colIndex = i;
                    break;
                }
            }

            return colIndex;
        }

        public void READ_IDOCTOR_COMP15(ref IDOCTOR_REC a)
        {
            set_col_checked(ref a, true);
            DEFAULT_IDOCTOR_REC(ref a);
            RunSql.Clear();

            RunSql.AppendText("READ FROM :TABLEFD");
            RunSql.AppendText(" EQUAL :DOCTOR_NO;");
            shareutils myUtils = new shareutils();
            myUtils.BindByName(ref RunSql, "I", "TABLEFD", a.FD);
            myUtils.BindByName(ref RunSql, "S", "DOCTOR_NO", a.DOCTOR_NO.Substring(0, 6));

            //try
            //{
            //    CommStr = 
            //}
            //catch
            //{
            //    a.ERR = 1;
            //}
            
        }

        public void set_col_checked(ref IDOCTOR_REC a, bool value)
        {
            for (int i = 0; i < a.COL_CHECKED.Count(); i++)
            {
                a.COL_CHECKED[i] = value;
            }
        }

        public string delete_space(string origstring)
        {
            return origstring.Replace(" ", "").Replace("　", "");
        }

        public void DEFAULT_IDOCTOR_REC(ref IDOCTOR_REC a)
        {
            IDOCTOR_REC b = new IDOCTOR_REC();
            INIT_IDOCTOR(ref b);
            if (a.DOCTOR_NO.Trim() == "")
            {
                a.DOCTOR_NO = b.DOCTOR_NO;
            }
            if (a.ID_NO.Trim() == "")
            {
                a.ID_NO = b.ID_NO;
            }
            if (a.DOCTOR_NAME.Trim() == "")
            {
                a.DOCTOR_NAME = b.DOCTOR_NAME;
            }
            if (a.DIV_NO.Trim() == "")
            {
                a.DIV_NO = b.DIV_NO;
            }
            if (a.DEGREE.Trim() == "")
            {
                a.DEGREE = b.DEGREE;
            }
            if (a.R.Trim() == "")
            {
                a.R = b.R;
            }
            if (a.REMARK.Trim() == "")
            {
                a.REMARK = b.REMARK;
            }
            if (a.DELETE_FLAG.Trim() == "")
            {
                a.DELETE_FLAG = b.DELETE_FLAG;
            }
            if (a.REPORT_DR.Trim() == "")
            {
                a.REPORT_DR = b.REPORT_DR;
            }
            if (a.ZONE.Trim() == "")
            {
                a.ZONE = b.ZONE;
            }
            if (a.FILLER1.Trim() == "")
            {
                a.FILLER1 = b.FILLER1;
            }
        }

        public void INIT_IDOCTOR(ref IDOCTOR_REC a)
        {
            a.DOCTOR_NO.PadRight(6, ' ');
            a.ID_NO.PadRight(10, ' ');
            a.DOCTOR_NAME.PadRight(10, ' ');
            a.DIV_NO.PadRight(2, ' ');
            a.DEGREE.PadRight(4, ' ');
            a.R.PadRight(6, ' ');
            a.REMARK.PadRight(2, ' ');
            a.DELETE_FLAG.PadRight(1, ' ');
            a.REPORT_DR.PadRight(6, ' ');
            a.ZONE.PadRight(1, ' ');
            a.FILLER1.PadRight(80, ' ');
            a.COL_LEN[0] = 6;
            a.COL_NAME[0] = "ID_DOCTOR_NO";
            a.COL_LEN[1] = 10;
            a.COL_NAME[1] = "ID_ID_NO";
            a.COL_LEN[2] = 10;
            a.COL_NAME[2] = "ID_DOCTOR_NAME";
            a.COL_LEN[3] = 2;
            a.COL_NAME[3] = "ID_DIV_NO";
            a.COL_LEN[4] = 4;
            a.COL_NAME[4] = "ID_DEGREE";
            a.COL_LEN[5] = 6;
            a.COL_NAME[5] = "ID_R";
            a.COL_LEN[6] = 2;
            a.COL_NAME[6] = "ID_REMARK";
            a.COL_LEN[7] = 1;
            a.COL_NAME[7] = "ID_DELETE_FLAG";
            a.COL_LEN[8] = 6;
            a.COL_NAME[8] = "ID_REPORT_DR";
            a.COL_LEN[9] = 1;
            a.COL_NAME[9] = "ID_ZONE";
            a.COL_LEN[10] = 80;
            a.COL_NAME[10] = "ID_FILLER1";
            a.FD = -1;
            a.DATASTR = " ";
            a.ERR = 0;
            a.ERR_MSG = "";
            a.COLS = 11;
            a.FNAME = "IDOCTOR";
            a.DRIVE = "MAS";
            a.SF = " ";
            a.UF = " ";
            a.DF = " ";
            for (int i = 0; i < 11; i++)
            {
                a.DF += a.DF + a.COL_NAME[i] + ",";
            }
            //TODO:多此一舉??
            a.DF = a.DF.Substring(0);

            a.ROWID = " ";
            set_col_checked(ref a, true);

        }

    }

    public class IDOCTOR_REC
    {
        public string DOCTOR_NO { get; set; }
        public string ID_NO { get; set; }
        public string DOCTOR_NAME { get; set; }
        public string DIV_NO { get; set; }
        public string DEGREE { get; set; }
        public string R { get; set; }
        public string REMARK { get; set; }
        public string DELETE_FLAG { get; set; }
        public string REPORT_DR { get; set; }
        public string ZONE { get; set; }
        public string FILLER1 { get; set; }
        public int FD { get; set; }
        public string DATASTR { get; set; }
        public int ERR { get; set; }
        public string ERR_MSG { get; set; }
        public int COLS { get; set; }
        //length:1..11
        public int[] COL_LEN { get; set; }
        //length:1..11
        public string[] COL_NAME { get; set; }
        //length:1..11
        public bool[] COL_CHECKED { get; set; }
        public string FNAME { get; set; }
        public string DRIVE { get; set; }
        public string SF { get; set; }
        public string UF { get; set; }
        public string DF { get; set; }
        public string ROWID { get; set; }
    }

}
