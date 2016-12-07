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

namespace WindowsFormsApplication1
{
    public partial class ObecnaPogoda : Form, IObecnaPogoda
    {
        public static string UstawWartość = "";

        public ObecnaPogoda()
        {
            // Inicjalizacja wszystkich elemntów i nadanie nazwy programowi
            InitializeComponent();
            this.Text = "Aplikacja pogodowa";
            button1.Click += button1_Click_1;
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //Podpowiedzi do pól tekstowych wprowadzania danych
            System.Windows.Forms.ToolTip Podpowiedź1 = new System.Windows.Forms.ToolTip();
            Podpowiedź1.SetToolTip(this.textBox1, "Podaj miasto do wyszukania");
            System.Windows.Forms.ToolTip Podpowiedź2 = new System.Windows.Forms.ToolTip();
            Podpowiedź2.SetToolTip(this.textBox8, "Skrót państwa np. pl");  
        }
        private async void button1_Click_1(object sender, EventArgs e)
        {
            //Pobieranie po kliknieciu dla miasta danych pogodowych
            //Sprawdzenie przy tym czy klient wpisał dane
            string tekst1;
            tekst1 = textBox1.Text;
            string tekst2;
            tekst2 = textBox8.Text;

            try
            {
                UzyskiwanieWartości uzyskano = new UzyskiwanieWartości();
                ZmiennePogoda pogoda = await uzyskano.OtrzymajPogodę(tekst1, tekst2);
                switch (pogoda.Widoczność)
                {
                    // Pobranie w zależności od warunków pogodowych odpowiedniego zdjęcia
                    case "Rain":
                        pogoda.Widoczność = "deszczowo";
                        pictureBox1.Load("http://openweathermap.org/img/w/10d.png");
                        break;

                    case "Clouds":
                        pogoda.Widoczność = "z chmurami";
                        pictureBox1.Load("http://openweathermap.org/img/w/02d.png");
                        break;

                    case "Clear":
                        pogoda.Widoczność = "bez chmurnie";
                        pictureBox1.Load("http://openweathermap.org/img/w/01d.png");
                        break;

                    case "Mist":
                        pogoda.Widoczność = "mglisto";
                        pictureBox1.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Haze":
                        pogoda.Widoczność = "mglisto";
                        pictureBox1.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Snow":
                        pogoda.Widoczność = "śnieżnie";
                        pictureBox1.Load("http://openweathermap.org/img/w/13d.png");
                        break;

                }
                label9.Text = pogoda.Tytuł;
                label11.Text = pogoda.Temperatura;
                label14.Text = pogoda.Wiatr;
                label12.Text = pogoda.Wilgotność;
                label15.Text = pogoda.Widoczność;
                label13.Text = pogoda.WschódSłońca;
                label16.Text = pogoda.ZachódSłońca;

                UstawWartość = label9.Text;
            }
            catch
            {
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                // Zapis do pliku (np. w celu własnej rejestracji warunków pogodowych na przestrzeni kilku dni)
                string Tytuł = label9.Text;
                string Temperatura = label11.Text;
                string Wiatr = label14.Text;
                string Wilgotność = label12.Text;
                string Widoczność = label15.Text;
                string WschódSłońca = label13.Text;
                string ZachódSłońca = label16.Text;
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
       
        public void button2_Click(object sender, EventArgs e)
        {
            // Po kliknieciu przycisku uruchomienie fragmentu z prognozą pogody na kolejne dni
            DalszaPogoda załaduj = new DalszaPogoda();
            załaduj.ShowDialog();
        }

      

        

       

       

       

        

       

    }
}
