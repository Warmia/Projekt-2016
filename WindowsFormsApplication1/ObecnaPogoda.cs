﻿using System;
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
        public static string SetValue = "";

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
                ZmiennePogoda weather = await uzyskano.GetWeather(tekst1, tekst2);
                switch (weather.Visibility)
                {
                    // Pobranie w zależności od warunków pogodowych odpowiedniego zdjęcia
                    case "Rain":
                        weather.Visibility = "deszczowo";
                        pictureBox1.Load("http://openweathermap.org/img/w/10d.png");
                        break;

                    case "Clouds":
                        weather.Visibility = "z chmurami";
                        pictureBox1.Load("http://openweathermap.org/img/w/02d.png");
                        break;

                    case "Clear":
                        weather.Visibility = "bez chmurnie";
                        pictureBox1.Load("http://openweathermap.org/img/w/01d.png");
                        break;

                    case "Mist":
                        weather.Visibility = "mglisto";
                        pictureBox1.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Haze":
                        weather.Visibility = "mglisto";
                        pictureBox1.Load("http://openweathermap.org/img/w/50d.png");
                        break;
                    case "Snow":
                        weather.Visibility = "śnieżnie";
                        pictureBox1.Load("http://openweathermap.org/img/w/13d.png");
                        break;

                }
                label9.Text = weather.Title;
                label11.Text = weather.Temperature;
                label14.Text = weather.Wind;
                label12.Text = weather.Humidity;
                label15.Text = weather.Visibility;
                label13.Text = weather.Sunrise;
                label16.Text = weather.Sunset;

                SetValue = label9.Text;
            }
            catch
            {
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }
        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                // Zapis do pliku (np. w celu własnej rejestracji warunków pogodowych na przestrzeni kilku dni)
                string Title = label9.Text;
                string Temperature = label11.Text;
                string Wind = label14.Text;
                string Humidity = label12.Text;
                string Visibility = label15.Text;
                string Sunrise = label13.Text;
                string Sunset = label16.Text;
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Projekt\WindowsFormsApplication1\Pogoda.txt", true))
                {
                    file.WriteLine("Tytuł:" + Title);
                    file.WriteLine("Temperatura:" + Temperature);
                    file.WriteLine("Wiatr:" + Wind);
                    file.WriteLine("Wilgotność:" + Humidity);
                    file.WriteLine("Widoczność:" + Visibility);
                    file.WriteLine("Wschód słońca:" + Sunrise);
                    file.WriteLine("Zachód słońca:" + Sunset);
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
            DalszaPogoda load = new DalszaPogoda();
            load.ShowDialog();
        }

      

        

       

       

       

        

       

    }
}