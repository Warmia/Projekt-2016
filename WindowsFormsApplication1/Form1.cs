using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Sample Weather App";
            button1.Click += button1_Click_1;

            
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
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
            //Pobieranie dla miasta po kliknieciu danych pogodowych
            string tekst1;
            tekst1 = textBox1.Text;
            string tekst2;
            tekst2 = textBox8.Text;

            Weather weather = await Class1.GetWeather(tekst1, tekst2);
            label9.Text = weather.Title;
            textBox2.Text = weather.Temperature;
            textBox3.Text = weather.Wind;
            textBox4.Text = weather.Humidity;
            if (weather.Visibility == "Rain")
            {
                weather.Visibility = "deszcz";
                pictureBox1.Load("C:\\Users\\samsung\\Desktop\\Obrazy\\Pogoda\\rain.png");
            }
            if (weather.Visibility == "Clouds")
            {
                weather.Visibility = "z chmurami";
                pictureBox1.Load("C:\\Users\\samsung\\Desktop\\Obrazy\\Pogoda\\cloud (2).png");
            }
            if (weather.Visibility == "Clear")
            {
                weather.Visibility = "bez chmurnie";
                pictureBox1.Load("C:\\Users\\samsung\\Desktop\\Obrazy\\Pogoda\\sunny.png");
            }
            textBox5.Text = weather.Visibility;
            textBox6.Text = weather.Sunrise;
            textBox7.Text = weather.Sunset;
        }
    }
}
