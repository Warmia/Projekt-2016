using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private  void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private const string API_KEY = "f8dc63a23acc6e0e69070a66a3c01c0a";
        private const string ForecastUrl = "http://api.openweathermap.org/data/2.5/forecast?" + "q=@LOC@&mode=xml&units=Metric&APPID=" + API_KEY;



       

        private void Form2_Load_1(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValue;
        }

        private void lvwTemps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string url = ForecastUrl.Replace("@LOC@", label1.Text);
            XmlDocument xml_doc;
            using (WebClient client = new WebClient())
            {
                
                string xml = client.DownloadString(url);

                
                xml_doc = new XmlDocument();
                xml_doc.LoadXml(xml);
            }
            ListTemperatures(xml_doc);

            Cursor = Cursors.Default; 
        }
        private void ListTemperatures(XmlDocument xml_doc)
        {
            lvwTemps.Items.Clear();


            string last_day = "";
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {

                XmlAttribute time_attr = time_node.Attributes["from"];
                DateTime start_time = DateTime.Parse(time_attr.Value);


                start_time = start_time.ToLocalTime();


                start_time += new TimeSpan(1, 30, 0);


                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                XmlAttribute temp_attr = temp_node.Attributes["value"];
                float temp = 0;
                if (temp_attr != null)
                {
                    temp = float.Parse(temp_attr.Value.ToString(), CultureInfo.InvariantCulture);
                }

                ListViewItem item;
                if (start_time.DayOfWeek.ToString() == last_day)
                {
                    item = lvwTemps.Items.Add("");
                }
                else
                {
                    last_day = start_time.DayOfWeek.ToString();
                    item = lvwTemps.Items.Add(last_day);
                }
                item.SubItems.Add(start_time.ToShortTimeString());
                item.SubItems.Add(temp.ToString("0.00"));
            }
        }


    }
}
