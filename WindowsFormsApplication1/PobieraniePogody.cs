using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace PogodaApp
{
    class PobieraniePogody 
    {
            public static async Task<dynamic> otrzymajDane(string tekstZapytania)
            {
                // Stworzenie obiektu client klasy HttpClient i zmiennej response zawierającej odpowiedź na zapytanie queryString
                HttpClient klient = new HttpClient();
                var odpowiedź = await klient.GetAsync(tekstZapytania);
                

                // Pobieranie przy pomocy json obecnych danych
                dynamic dane = null;
                if (odpowiedź != null)
                {
                    string json = odpowiedź.Content.ReadAsStringAsync().Result;
                    dane = JsonConvert.DeserializeObject(json);
                }

                return dane;
            }
     
        
    }
}
