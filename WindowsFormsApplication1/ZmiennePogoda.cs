using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ZmiennePogoda
    {
            // Metody do pobierania i ustawiania elemntów 
            public string Tytuł { get; set; }
            public string Temperatura { get; set; }
            public string Wiatr { get; set; }
            public string Wilgotność { get; set; }
            public string Widoczność { get; set; }
            public string WschódSłońca { get; set; }
            public string ZachódSłońca { get; set; }
            // Konstruktor nadający metodom wartość pustego łańcucha znakowego
            public ZmiennePogoda()
            {
                this.Tytuł = " ";
                this.Temperatura = " ";
                this.Wiatr = " ";
                this.Wilgotność = " ";
                this.Widoczność = " ";
                this.WschódSłońca = " ";
                this.ZachódSłońca = " ";
            }
    }
}
