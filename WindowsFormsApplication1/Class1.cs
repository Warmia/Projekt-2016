﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public static async Task<Weather> GetWeather(string city,string country)
        {
            // Darmowy klucz dostępu oraz zapytanie do strony
            string key = "f8dc63a23acc6e0e69070a66a3c01c0a";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + city + "," + country + ",us&appid=" + key + "&units=Metric";

            dynamic results = await DataServices.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " °C";
                weather.Wind = (string)results["wind"]["speed"] + " km/h";
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