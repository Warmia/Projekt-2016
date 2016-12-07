using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class UzyskiwanieWartości : AbstrakcyjneWartości 
    {
        override public  async Task<ZmiennePogoda> OtrzymajPogodę(string miasto,string kraj)
        {
            // Darmowy klucz dostępu oraz zapytanie do strony
            string klucz = "f8dc63a23acc6e0e69070a66a3c01c0a";
            string tekstZapytania = "http://api.openweathermap.org/data/2.5/weather?q="
                + miasto + "," + kraj + "&appid=" + klucz + "&units=metric";
            
            dynamic resultat = await PobieraniePogody.otrzymajDane(tekstZapytania).ConfigureAwait(false);

            // Jeżeli wartości pogody są różne od null to stwórz obiekt i przypisz mu odpowiednie pobrane wartości 
            if (resultat["weather"] != null)
            {
                ZmiennePogoda pogoda = new ZmiennePogoda();
                pogoda.Tytuł = (string)resultat["name"];
                pogoda.Temperatura = (string)resultat["main"]["temp"] + " °C";
                pogoda.Wiatr = (string)resultat["wind"]["speed"] + " m/s";
                pogoda.Wilgotność = (string)resultat["main"]["humidity"] + " %";
                pogoda.Widoczność = (string)resultat["weather"][0]["main"];

                DateTime czas = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime WschódSłońca = czas.AddSeconds((double)resultat["sys"]["sunrise"]);
                DateTime ZachódSłońca = czas.AddSeconds((double)resultat["sys"]["sunset"]);
                pogoda.WschódSłońca = WschódSłońca.ToString() + " UTC";
                pogoda.ZachódSłońca = ZachódSłońca.ToString() + " UTC";
                return pogoda;
            }
            else
            {
                return null;
            }
           
        }
    }
}
