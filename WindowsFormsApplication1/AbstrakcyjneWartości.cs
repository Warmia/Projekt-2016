﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    abstract class AbstrakcyjneWartości
    {
        virtual public async Task<ZmiennePogoda> GetWeather(string city, string country)
        {
            // Darmowy klucz dostępu oraz zapytanie do strony
            string key = "f66698a6d7e3t2h3x5c7a70a66a3c01c0a";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + city + "&appid=" + key + "&units=imperial";

            dynamic results = await PobieraniePogody.getDataFromService(queryString).ConfigureAwait(false);

            // Jeżeli wartości pogody są różne od null to stwórz obiekt i przypisz mu odpowiednie pobrane wartości 
            if (results["weather"] != null)
            {
                ZmiennePogoda weather = new ZmiennePogoda();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " °C";
                weather.Wind = (string)results["wind"]["speed"] + " m/s";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
