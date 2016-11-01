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
            button1.Click += button1_Click;

            
           
        }
        
        
        private async void button1_Click(object sender, EventArgs e)
        {
            //Pobieranie dla miasta po kliknieciu danych pogodowych
            Weather weather = await Class1.GetWeather("Olsztyn","pl");
            textBox1.Text = weather.Temperature;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
