using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace LightKcpClient
{
    public partial class frm_Main : Form
    {
        private newConfig m_conf;

        public frm_Main()
        {
            InitializeComponent();
            m_conf = JsonOperater.ReadJson();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            txtPort.Text = m_conf.localaddr == null ? "" : m_conf.localaddr.Replace(":", "");
            txtPort.Text = m_conf.localaddr?.Replace(":", "");
            txtPwd.Text = m_conf.key;
            string[] sTemp = m_conf.remoteaddr?.Split(':');
            if (sTemp!=null&&sTemp.Count()==2)
            {
                txtIP.Text = sTemp[0];
                txtKcpPort.Text = sTemp[1];
            }
            else
            {
                txtIP.Text = string.Empty;
                txtKcpPort.Text = string.Empty;
            }

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToObject();
                frm_Setting frmSetting = new frm_Setting(m_conf);
                frmSetting.ShowDialog();
            }
            catch 
            {
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToObject();
                JsonOperater.WriteJson(m_conf);
                StringBuilder sb = new StringBuilder();
                foreach (var item in m_conf.GetType().GetProperties())
                {
                    if (item.Name == "key")
                        sb.Append(string.Format("-{0} {1} ", item.Name, item.GetValue(m_conf, null)));
                    else if (item.PropertyType.Equals(typeof(bool)))
                    {
                        if ((bool)item.GetValue(m_conf, null) == true)
                            sb.Append("-" + item.Name + " ");
                    }
                    else
                        sb.Append(string.Format("-{0} {1} ", item.Name, item.GetValue(m_conf, null)));
                }

                string sParamer = sb.ToString();

                Process p = new Process();
                p.StartInfo.FileName = "client_windows_amd64.exe";
                p.StartInfo.Arguments = sParamer;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.Start();

                this.btnStart.Enabled = false;
                this.btnStop.Enabled = true;
            }
            catch 
            {
            }
        }

        private void WriteToObject()
        {
            m_conf.localaddr = ":"+txtPort.Text;
            m_conf.remoteaddr = txtIP.Text + ":" + txtKcpPort.Text;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;

                foreach (var item in Process.GetProcessesByName("client_windows_amd64"))
                {
                    try
                    {
                        item.Kill();
                        item.WaitForExit(1000);
                    }
                    catch
                    {
                    }
                }
            }
            catch 
            {
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsiStart.Enabled = btnStart.Enabled;
            tsiStop.Enabled = btnStop.Enabled;
        }

        private void frm_Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right)
            {
                this.contextMenuStrip1.Show();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(null, null);
        }

        private void tsiStart_Click(object sender, EventArgs e)
        {
            btnStart_Click(null, null);
        }

        private void tsiStop_Click(object sender, EventArgs e)
        {
            btnStop_Click(null, null);
        }

        private void tsiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public static class JsonOperater
    {
        public static newConfig ReadJson()
        {
            string sFile = Assembly.GetExecutingAssembly().Location + @"\..\config.json";
            if (!File.Exists(sFile))
                return new newConfig();

            string sJson = File.ReadAllText(sFile);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            newConfig conf = ser.Deserialize<newConfig>(sJson);
            if (conf == null)
                conf = new newConfig();

            return conf;
        }

        public static void WriteJson(newConfig conf)
        {
            try
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string sjson = ser.Serialize(ser);
                string sFile = Assembly.GetExecutingAssembly().Location + @"\..\config.json";
                File.WriteAllText(sFile, sjson);
            }
            catch
            { }
        }
    }
}
