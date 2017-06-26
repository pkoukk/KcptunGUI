namespace LightKcpClient
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtKcpPort = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(95, 24);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(132, 25);
            this.txtIP.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(283, 116);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(391, 116);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 29);
            this.btnStop.TabIndex = 4;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.Location = new System.Drawing.Point(16, 116);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 29);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "KcpPort:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(347, 28);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(132, 25);
            this.txtPort.TabIndex = 1;
            // 
            // txtKcpPort
            // 
            this.txtKcpPort.Location = new System.Drawing.Point(95, 72);
            this.txtKcpPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKcpPort.Name = "txtKcpPort";
            this.txtKcpPort.Size = new System.Drawing.Size(132, 25);
            this.txtKcpPort.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(347, 72);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(132, 25);
            this.txtPwd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiStart,
            this.tsiStop,
            this.tsiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsiStart
            // 
            this.tsiStart.Name = "tsiStart";
            this.tsiStart.Size = new System.Drawing.Size(113, 24);
            this.tsiStart.Text = "Start";
            this.tsiStart.Click += new System.EventHandler(this.tsiStart_Click);
            // 
            // tsiStop
            // 
            this.tsiStop.Name = "tsiStop";
            this.tsiStop.Size = new System.Drawing.Size(113, 24);
            this.tsiStop.Text = "Stop";
            this.tsiStop.Click += new System.EventHandler(this.tsiStop_Click);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(113, 24);
            this.tsiExit.Text = "Exit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KcptunGui";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 154);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKcpPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KcpClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.SizeChanged += new System.EventHandler(this.frm_Main_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtKcpPort;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiStart;
        private System.Windows.Forms.ToolStripMenuItem tsiStop;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

