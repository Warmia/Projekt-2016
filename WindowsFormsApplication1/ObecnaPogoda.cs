using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Biblioteki do m.in. do operacji nad plikiem, czy tworzenia okna aplikacji

namespace PogodaApp
{
    /// <summary>
    /// Klasa ObecnaPogoda dziedziczy po systemowej klasie Form i interfejsie IObecnaPogoda
    /// </summary>
    public partial class ObecnaPogoda : Form, IObecnaPogoda
    {
        public static string UstawWartość = "";

        public ObecnaPogoda()
        {
            // Inicjalizacja wszystkich elemntów i nadanie nazwy programowi
            InitializeComponent();
            this.Text = "Aplikacja pogodowa";
            WyświetlObecną.Click += ŁadowanieFormularza;
        }
        public void ŁadowanieFormularza(object sender, EventArgs e)
        {
            //Podpowiedzi do pól tekstowych wprowadzania danych
            System.Windows.Forms.ToolTip Podpowiedź1 = new System.Windows.Forms.ToolTip();
            Podpowiedź1.SetToolTip(this.tekstMiasto, "Podaj miasto do wyszukania");
            System.Windows.Forms.ToolTip Podpowiedź2 = new System.Windows.Forms.ToolTip();
            Podpowiedź2.SetToolTip(this.tekstPaństwo, "Skrót państwa np. pl");  
        }
        private async void KliknieciePrzycisku(object sender, EventArgs e)
        {
            //Pobieranie po kliknieciu dla miasta danych pogodowych
            //Sprawdzenie przy tym czy klient wpisał dane
            string tekst1;
            tekst1 = tekstMiasto.Text;
            string tekst2;
            tekst2 = tekstPaństwo.Text;

            try
            {
                UzyskiwanieWartości uzyskano = new UzyskiwanieWartości();
                ZmiennePogoda pogoda = await uzyskano.OtrzymajPogodę(tekst1, tekst2);
                switch (pogoda.Widoczność)
                {
                    // Pobranie w zależności od warunków pogodowych odpowiedniego zdjęcia
                    case "Rain":
                        pogoda.Widoczność = "deszczowo";
                        Obrazek.Load("http://openweathermap.org/img/w/10d.png");
                        break;

                    case "Clouds":
                        pogoda.Widoczność = "z chmurami";
                        Obrazek.Load("http://openweathermap.org/img/w/02d.png");
                        break;

                    case "Clear":
                        pogoda.Widoczność = "bez chmurnie";
                        Obrazek.Load("http://openweathermap.org/img/w/01d.png");
                        break;

                    case "Mist":
                        pogoda.Widoczność = "mglisto";
                        Obrazek.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Haze":
                        pogoda.Widoczność = "mglisto";
                        Obrazek.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Snow":
                        pogoda.Widoczność = "śnieżnie";
                        Obrazek.Load("http://openweathermap.org/img/w/13d.png");
                        break;

                }
                TytułTekst.Text = pogoda.Tytuł;
                TemperaturaTekst.Text = pogoda.Temperatura;
                WiatrTekst.Text = pogoda.Wiatr;
                WilgotnośćTekst.Text = pogoda.Wilgotność;
                WidocznośćTekst.Text = pogoda.Widoczność;
                WschódTekst.Text = pogoda.WschódSłońca;
                ZachódTekst.Text = pogoda.ZachódSłońca;

                UstawWartość = TytułTekst.Text;
            }
            catch
            {
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
        public void ZapisDoPliku(object sender, EventArgs e)
        {
            // Zapis do pliku (np. w celu własnej rejestracji warunków pogodowych na przestrzeni kilku dni)
            string Tytuł = TytułTekst.Text;
            string Temperatura = TemperaturaTekst.Text;
            string Wiatr = WiatrTekst.Text;
            string Wilgotność = WilgotnośćTekst.Text;
            string Widoczność = WidocznośćTekst.Text;
            string WschódSłońca = WschódTekst.Text;
            string ZachódSłońca = ZachódTekst.Text;
            try
            {
                using (System.IO.StreamWriter plik = new System.IO.StreamWriter(@"D:\Projekt\WindowsFormsApplication1\Pogoda.txt", true))
                {
                    plik.WriteLine("Tytuł:" + Tytuł);
                    plik.WriteLine("Temperatura:" + Temperatura);
                    plik.WriteLine("Wiatr:" + Wiatr);
                    plik.WriteLine("Wilgotność:" + Wilgotność);
                    plik.WriteLine("Widoczność:" + Widoczność);
                    plik.WriteLine("Wschód słońca:" + WschódSłońca);
                    plik.WriteLine("Zachód słońca:" + ZachódSłońca);
                }
            }
            catch
            {
                MessageBox.Show("Nie zapisano pliku!", "Błąd zapisu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        
        public void PrzyciskPrzeniesienie(object sender, EventArgs e)
        {
            // Po kliknieciu przycisku uruchomienie fragmentu z prognozą pogody na kolejne dni
            DalszaPogoda załaduj = new DalszaPogoda();
            załaduj.ShowDialog();
        }

    }
}
