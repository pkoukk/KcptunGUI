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
        private Config m_conf;

        public frm_Main()
        {
            InitializeComponent();
            m_conf = JsonOperater.ReadJson();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            txtPort.Text = m_conf.localaddr == null ? "" : m_conf.localaddr.Replace(":", "");
            txtPwd.Text = m_conf.key;
            string[] sTemp = m_conf.remoteaddr == null ? null : m_conf.remoteaddr.Split(':');
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
                StringBuilder sb = new StringBuilder();
                foreach (var item in m_conf.GetType().GetProperties())
                {
                    sb.Append(string.Format("--{0} {1}", item.Name, item.GetValue(m_conf, null)));
                }

                string sParamer = sb.ToString();

                Process p = new Process();
                p.StartInfo.FileName = "client_windows_amd64.exe";
                p.StartInfo.Arguments = sParamer;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
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
                foreach (var item in Process.GetProcesses("client_windows_amd64.exe"))
                {
                    try
                    {
                        item.Kill();
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
    }

    public static class JsonOperater
    {
        public static Config ReadJson()
        {
            string sFile = Assembly.GetExecutingAssembly().Location + @"\..\config.json";
            if (!File.Exists(sFile))
                return new Config();

            string sJson = File.ReadAllText(sFile);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Config conf = ser.Deserialize<Config>(sJson);
            if (conf == null)
                conf = new Config();

            return conf;
        }

        public static void WriteJson(Config conf)
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
