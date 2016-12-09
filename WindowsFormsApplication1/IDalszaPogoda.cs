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
        void UstawienieNazwy(object sender, EventArgs e);
        void KliknieciePrzycisku(object sender, EventArgs e);
        void ListaTemperatur(XmlDocument xml_doc);
    }
}
