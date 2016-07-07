using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Travel.Core.DomainEntities;

namespace Travel.Core
{
    public static class Helper
    {
        public static WeatherInformation GetWeatherInfo(string location)
        {
            string appId = "bd83daab4507534bde7f44804b5e365e";
            WeatherInformation weatherInfo = new WeatherInformation();
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/weekly?q={0}&units=metric&cnt=7&APPID={1}", location, appId);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInformation>(json);
            }

            return weatherInfo;
        }

    }
}
