﻿using System;
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
    public partial class DalszaPogoda : Form, IInterakcja2
    {
        public DalszaPogoda()
        {
            InitializeComponent();
        }
        private  void Form2_Load(object sender, EventArgs e)
        {
            

        }
        // Klucz programu i link do prognozy pogody 5dni/3godziny
        private const string API_KEY = "f8dc63a23acc6e0e69070a66a3c01c0a";
        private const string ForecastUrl = "http://api.openweathermap.org/data/2.5/forecast?" + "q=@LOC@&mode=xml&units=Metric&APPID=" + API_KEY;



       

        public void Form2_Load_1(object sender, EventArgs e)
        {
            // Ustawienie automatycznie nazwy miejscowości z pierwszej strony programu na drugiej stronie
            label1.Text = ObecnaPogoda.SetValue;
        }

        private void lvwTemps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            //Po kliknieciu pobranie pliku w formacie xml z strony i sprawdzenie poprawności wczytania danych
            Cursor = Cursors.WaitCursor;

            string url = ForecastUrl.Replace("@LOC@", label1.Text);
            XmlDocument xml_doc;
            try
            {
                using (WebClient client = new WebClient())
                {

                    string xml = client.DownloadString(url);


                    xml_doc = new XmlDocument();
                    xml_doc.LoadXml(xml);
                }


                ListTemperatures(xml_doc);
            }
            catch
            {
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            
            
        }
        public void ListTemperatures(XmlDocument xml_doc)
        {
            lvwTemps.Items.Clear();

            string last_day = "";
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
                // Uzyskanie z pliku xml fragmentu odpowiadającego za czas i m.in. konwersja czasu do lokalnej jej wersji
                XmlAttribute time_attr = time_node.Attributes["from"];
                DateTime start_time = DateTime.Parse(time_attr.Value);


                start_time = start_time.ToLocalTime();


                start_time += new TimeSpan(1, 30, 0);
                string  day = start_time.DayOfWeek.ToString();

                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość temperatury 
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                XmlAttribute temp_attr = temp_node.Attributes["value"];
                float temp = 0;
                if (temp_attr != null)
                {
                    temp = float.Parse(temp_attr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość predkości wiatru
                XmlNode wind_node = time_node.SelectSingleNode("windSpeed");
                XmlAttribute wind_attr = wind_node.Attributes["mps"];
                float wind = 0;
                if (wind_attr != null)
                {
                    wind = float.Parse(wind_attr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość wilgotności
                XmlNode humidity_node = time_node.SelectSingleNode("humidity");
                XmlAttribute humidity_attr = humidity_node.Attributes["value"];
                float humidity = 0;
                if (humidity_attr != null)
                {
                    humidity = float.Parse(humidity_attr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                ListViewItem item;
                //Uzyskanie z daty dnia tygodnia i dodanie go do programu
                switch (day)
                {
                    case "Monday":
                    day = "Poniedziałek";
                    break;
                    case "Tuesday":
                    day = "Wtorek";
                    break;
                    case "Wednesday":
                    day = "Środa";
                    break;
                    case "Thursday":
                    day = "Czwartek";
                    break;
                    case "Friday":
                    day = "Piątek";
                    break;
                    case "Saturday":
                    day = "Sobota";
                    break;
                    case "Sunday":
                    day = "Niedziela";
                    break;
                }
                if (day == last_day)
                {
                    item = lvwTemps.Items.Add("");
                }
                else
                {
                    
                    item = lvwTemps.Items.Add(day);
                }
                //Ustawienie formatu wyświetlanych danych
                item.SubItems.Add(start_time.ToShortTimeString());
                item.SubItems.Add(temp.ToString("0.00"));
                item.SubItems.Add(wind.ToString("0.00"));
                item.SubItems.Add(humidity.ToString("0.00"));

                
                
                WeatherChart.ChartAreas[0].CursorX.IsUserEnabled = true;
                WeatherChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                WeatherChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                WeatherChart.Series[0].Points.AddXY(day + " " + start_time.ToShortTimeString(), temp);
                WeatherChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                
            }
           
        }
    }
}
