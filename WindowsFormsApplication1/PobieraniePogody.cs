using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WindowsFormsApplication1
{
    class PobieraniePogody 
    {
            public static async Task<dynamic> getDataFromService(string queryString)
            {
                // Stworzenie obiektu client klasy HttpClient i zmiennej response zawierającej odpowiedź na zapytanie queryString
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(queryString);
                

                // Pobieranie przy pomocy json obecnych danych
                dynamic data = null;
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }

                return data;
            }
     
        
    }
}
