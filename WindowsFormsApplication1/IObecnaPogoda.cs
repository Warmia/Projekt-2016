using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaApp
{
    interface IObecnaPogoda
    {

        void ŁadowanieFormularza(object sender, EventArgs e);
        void ZapisDoPliku(object sender, EventArgs e);
        void PrzyciskPrzeniesienie(object sender, EventArgs e);
    }
}
