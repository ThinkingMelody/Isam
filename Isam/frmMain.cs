using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Isam
{
    public partial class frmMain : Form
    {
        TcpClient clientSocket = new TcpClient();
        public frmMain()
        {
            InitializeComponent();
            cbxHostList.Items.Add(new CComboBoxItem("", "請選擇"));
            cbxHostList.Items.Add(new CComboBoxItem("192.9.10.99 2001", "中港-測試"));
            cbxHostList.Items.Add(new CComboBoxItem("192.9.20.99 2001", "平等-測試"));
            cbxHostList.Items.Add(new CComboBoxItem("192.9.10.100 2000", "中港-正式"));
            cbxHostList.Items.Add(new CComboBoxItem("192.9.20.100 2000", "平等-正式"));
            cbxHostList.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CComboBoxItem myItem = (CComboBoxItem)(cbxHostList.Items[cbxHostList.SelectedIndex]);
            
            if (myItem.Value == "")
            {
                MessageBox.Show("請選擇欲連線主機!!");                
            }
            else
            {
                string[] strIP = myItem.Value.Split(' ');
                try
                {
                    clientSocket.Connect(strIP[0], Int32.Parse(strIP[1]));
                    tsslConnectStatus.Text = myItem.Text + "已連線!";
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                }
                catch (Exception ex)
                {
                    clientSocket.Close();
                    throw ex;
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                clientSocket = null;
                throw ex;
            }
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(tbxCommand.Text.Trim());
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            try
            {
                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                tbxMessage.Text += tbxMessage.Text + Environment.NewLine + " >> " + returndata;
            }
            catch (Exception ex)
            {
                clientSocket.Close();
                throw ex;
            }
        }
    }
}
