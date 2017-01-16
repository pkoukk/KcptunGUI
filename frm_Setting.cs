using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace LightKcpClient
{
    public partial class frm_Setting : Form
    {
        private Config m_config;

        public frm_Setting(Config conf)
        {
            InitializeComponent();
            m_config = conf;
        }

        private void frm_Setting_Load(object sender, EventArgs e)
        {
            List<ParamerItem> listItems = new List<ParamerItem>();
            ParamerItem paramer;
            foreach (var item in m_config.GetType().GetProperties())
            {
                paramer = new ParamerItem();
                paramer.Name = item.Name;
                paramer.Vaule= item.GetValue(m_config, null).ToString();
                listItems.Add(paramer);
            }

            dataGridView1.DataSource = listItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<ParamerItem> items = dataGridView1.DataSource as List<ParamerItem>;
                Type t = m_config.GetType();
                foreach (var item in items)
                {
                    PropertyInfo info = t.GetProperty(item.Name);
                    if (info.PropertyType.Equals(typeof(string)))
                        info.SetValue(m_config, item.Vaule, null);
                    else if (info.PropertyType.Equals(typeof(int)))
                        info.SetValue(m_config, int.Parse(item.Vaule), null);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch 
            {
            }
        }
    }

    public class ParamerItem
    {
        public string Name { get; set; }

        public string Vaule { get; set; }
    }
    public class Config
    {
        /// <summary>
        /// 
        /// </summary>
        public string localaddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remoteaddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string crypt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int conn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int autoexpire { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int mtu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sndwnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rcvwnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int datashard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int parityshard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int dscp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nocomp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string acknodelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nodelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int interval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int resend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sockbuf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int keepalive { get; set; }
    }
}
