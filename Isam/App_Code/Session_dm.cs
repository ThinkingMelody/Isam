using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Isam.App_Code
{
    public class Session_dm
    {
        #region "TForm"
        readonly string MASTER_IP = "89.0.0.61";
        readonly string SECOND_IP = "89.0.0.61";
        readonly int MASTER_PORT = 2003;
        readonly int SECOND_PORT = 2003;
        public bool is_conn;

        TcpClient cs1, cs2, csTime;
        TextBox EditN1;
        #endregion

        string debug_flas, cstr, rStr, TempStr, owner, DefaultHost, DefaultPORT;
        int rValue, State, ReadByte, TotLen, RealLen;
        bool ScoketFlag, port1_ok, port2_ok;
        NetworkStream st1, st2, stTime;
        char[] Buff = new char[4095];

        public Session_dm()
        {

        }

        //public void sync_date_time_with_host()
        //{
        //    string DatetimeStr;
        //    DateTime SysDateTime;


        //}


        //public string GetHostDateTime()
        //{
        //    FillChar(ref Buff, '0');
        //    csTime.Connect
        //}

        //public int getData(String CommStr, ref string ReceiveStr)
        //{

        //}

        public void FillChar(ref char[] buff, char word)
        {
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = word;
            }
        }

        //TForm_Create

        //TForm_Close
    }
}
