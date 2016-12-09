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

namespace PogodaApp
{
    /// <summary>
    /// Klasa DalszaPogoda dziedziczy po systemowej klasie Form i interfejsie IDalszaPogoda
    /// </summary>
    public partial class DalszaPogoda : Form, IDalszaPogoda
    {
        public DalszaPogoda()
        {
            InitializeComponent();
        }
        
        // Klucz programu i link do prognozy pogody 5dni/3godziny
        private const string API_KLUCZ = "f8dc63a23acc6e0e69070a66a3c01c0a";
        private const string PrognozaUrl = "http://api.openweathermap.org/data/2.5/forecast?" + "q=@LOC@&mode=xml&units=Metric&APPID=" + API_KLUCZ;

        public void UstawienieNazwy(object sender, EventArgs e)
        {
            // Ustawienie automatycznie nazwy miejscowości z pierwszej strony programu na drugiej stronie
            Miejscowość.Text = ObecnaPogoda.UstawWartość;
        }

        public void KliknieciePrzycisku(object sender, EventArgs e)
        {
            //Po kliknieciu pobranie pliku w formacie xml z strony i sprawdzenie poprawności wczytania danych
            Cursor = Cursors.WaitCursor;

            string url = PrognozaUrl.Replace("@LOC@", Miejscowość.Text);
            XmlDocument xml_doc;
            try
            {
                using (WebClient klient = new WebClient())
                {

                    string xml = klient.DownloadString(url);

                    xml_doc = new XmlDocument();
                    xml_doc.LoadXml(xml);
                }

                ListaTemperatur(xml_doc);
            }
            catch
            {
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            
        }
        public void ListaTemperatur(XmlDocument xml_doc)
        {
            WarunkiPrognoza.Items.Clear();

            string ostatni_dzień = "";
            foreach (XmlNode czasu_węzeł in xml_doc.SelectNodes("//time"))
            {
                // Uzyskanie z pliku xml fragmentu odpowiadającego za czas i m.in. konwersja czasu do lokalnej jej wersji
                XmlAttribute czas_atr = czasu_węzeł.Attributes["from"];
                DateTime start_czas = DateTime.Parse(czas_atr.Value);

                start_czas = start_czas.ToLocalTime();

                start_czas += new TimeSpan(1, 30, 0);
                string  dzień = start_czas.DayOfWeek.ToString();

                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość temperatury 
                XmlNode temperatury_węzeł = czasu_węzeł.SelectSingleNode("temperature");
                XmlAttribute temp_atr = temperatury_węzeł.Attributes["value"];
                float temp = 0;
                if (temp_atr != null)
                {
                    temp = float.Parse(temp_atr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość predkości wiatru
                XmlNode wiatru_węzeł = czasu_węzeł.SelectSingleNode("windSpeed");
                XmlAttribute wiatr_atr = wiatru_węzeł.Attributes["mps"];
                float wiatr = 0;
                if (wiatr_atr != null)
                {
                    wiatr = float.Parse(wiatr_atr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                //Uzyskanie z pliku xml fragmentu odpowiadającego za wartość wilgotności
                XmlNode wilgotności_węzeł = czasu_węzeł.SelectSingleNode("humidity");
                XmlAttribute wilg_atr = wilgotności_węzeł.Attributes["value"];
                float wilgotność = 0;
                if (wilg_atr != null)
                {
                    wilgotność = float.Parse(wilg_atr.Value.ToString(), CultureInfo.InvariantCulture);
                }
                ListViewItem item;
                //Uzyskanie z daty dnia tygodnia i dodanie go do programu
                switch (dzień)
                {
                    case "Monday":
                    dzień = "Poniedziałek";
                    break;
                    case "Tuesday":
                    dzień = "Wtorek";
                    break;
                    case "Wednesday":
                    dzień = "Środa";
                    break;
                    case "Thursday":
                    dzień = "Czwartek";
                    break;
                    case "Friday":
                    dzień = "Piątek";
                    break;
                    case "Saturday":
                    dzień = "Sobota";
                    break;
                    case "Sunday":
                    dzień = "Niedziela";
                    break;
                }
                if (dzień == ostatni_dzień)
                {
                    item = WarunkiPrognoza.Items.Add("");
                }
                else
                {
                    
                    item = WarunkiPrognoza.Items.Add(dzień);
                }
                //Ustawienie formatu wyświetlanych danych
                item.SubItems.Add(start_czas.ToShortTimeString());
                item.SubItems.Add(temp.ToString("0.00"));
                item.SubItems.Add(wiatr.ToString("0.00"));
                item.SubItems.Add(wilgotność.ToString("0.00"));

                //Tworzenie wykresu z dwoma seriami(wykresami) danych
                WykresPogoda.ChartAreas[0].CursorX.IsUserEnabled = true;
                WykresPogoda.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                WykresPogoda.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                WykresPogoda.Series[0].Points.AddXY(dzień + " " + start_czas.ToShortTimeString(), temp);
                WykresPogoda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                WykresPogoda.Series[1].Points.AddXY(dzień + " " + start_czas.ToShortTimeString(), wiatr);
                WykresPogoda.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
        }
    }
}
