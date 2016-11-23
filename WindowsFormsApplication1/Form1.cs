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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form, IFile
    {
        public static string SetValue = "";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Sample Weather App";
            button1.Click += button1_Click_1;

            
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Podpowiedzi do pól tekstowych wprowadzania danych
            System.Windows.Forms.ToolTip Podpowiedź1 = new System.Windows.Forms.ToolTip();
            Podpowiedź1.SetToolTip(this.textBox1, "Podaj miasto do wyszukania");
            System.Windows.Forms.ToolTip Podpowiedź2 = new System.Windows.Forms.ToolTip();
            Podpowiedź2.SetToolTip(this.textBox8, "Skrót państwa np. pl");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
           
            //Pobieranie po kliknieciu dla miasta danych pogodowych
            
            string tekst1;
            tekst1 = textBox1.Text;
            string tekst2;
            tekst2 = textBox8.Text;

            try
            {
                Weather weather = await Class1.GetWeather(tekst1, tekst2);
                switch (weather.Visibility)
                {
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
                MessageBox.Show("Nie wprowadzano danych!", "Błąd pobierania", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 load = new Form2();
            load.ShowDialog();
        }

       

       

       

        

       

    }
}
