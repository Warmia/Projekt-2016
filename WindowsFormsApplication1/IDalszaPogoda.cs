using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApplication1
{
    interface IInterakcja2
    {
        void Form2_Load_1(object sender, EventArgs e);
        void button2_Click(object sender, EventArgs e);
        void ListTemperatures(XmlDocument xml_doc);
    }
}
