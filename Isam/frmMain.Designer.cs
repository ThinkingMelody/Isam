namespace Isam
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxHostList = new System.Windows.Forms.ComboBox();
            this.lblConHost = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnectStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConnectStatus
            // 
            this.tsslConnectStatus.Name = "tsslConnectStatus";
            this.tsslConnectStatus.Size = new System.Drawing.Size(44, 17);
            this.tsslConnectStatus.Text = "未連線";
            this.tsslConnectStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(200, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxHostList
            // 
            this.cbxHostList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHostList.FormattingEnabled = true;
            this.cbxHostList.Location = new System.Drawing.Point(73, 19);
            this.cbxHostList.Name = "cbxHostList";
            this.cbxHostList.Size = new System.Drawing.Size(121, 20);
            this.cbxHostList.TabIndex = 2;
            // 
            // lblConHost
            // 
            this.lblConHost.AutoSize = true;
            this.lblConHost.Location = new System.Drawing.Point(12, 22);
            this.lblConHost.Name = "lblConHost";
            this.lblConHost.Size = new System.Drawing.Size(65, 12);
            this.lblConHost.TabIndex = 3;
            this.lblConHost.Text = "連線主機：";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(12, 58);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(65, 12);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "傳送指令：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 102);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 12);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "回傳資料：";
            // 
            // tbxCommand
            // 
            this.tbxCommand.Location = new System.Drawing.Point(83, 55);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(384, 22);
            this.tbxCommand.TabIndex = 6;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(14, 128);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMessage.Size = new System.Drawing.Size(534, 232);
            this.tbxMessage.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(290, 16);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "斷線";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(473, 53);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(75, 23);
            this.btnSendCommand.TabIndex = 9;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.lblConHost);
            this.Controls.Add(this.cbxHostList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "Isam測試工具";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxHostList;
        private System.Windows.Forms.Label lblConHost;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSendCommand;
    }
}

