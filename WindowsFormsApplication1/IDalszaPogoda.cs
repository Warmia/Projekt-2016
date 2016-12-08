using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PogodaApp
{
    interface IDalszaPogoda
    {
        void Form2_Load_1(object sender, EventArgs e);
        void button2_Click(object sender, EventArgs e);
        void ListaTemperatur(XmlDocument xml_doc);
    }
}
