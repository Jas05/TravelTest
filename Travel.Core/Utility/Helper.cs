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

        public static ActivityList GetActivites(string location, string startDate, string endDate)
        {
            string appId = "i4CjuKj4UwpiMla4r0Z1r648IaYjIoii";
            ActivityList activityList = new ActivityList();
            string url = string.Format("http://terminal2.expedia.com/x/activities/search?location={0}&startDate={1}&endDate={2}&apikey={3}", location, startDate, endDate, appId);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                activityList = (new JavaScriptSerializer()).Deserialize<ActivityList>(json);
            }

            return activityList;
        }

        public static CarHire GetCarHire(string pickuplocation, string dropofflocation, string dropoffdate, string pickupdate)
        {
            string appId = "i4CjuKj4UwpiMla4r0Z1r648IaYjIoii";
            CarHire activityList = new CarHire();
        
            string url = string.Format("http://terminal2.expedia.com:80/x/cars/search?pickupdate=2016-08-15T10%3A00&dropoffdate=2016-08-17T16%3A30&pickuplocation=PMI&dropofflocation=PMI&limit=10&apikey={0}", appId);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                activityList = (new JavaScriptSerializer()).Deserialize<CarHire>(json);
            }

            return activityList;
        }

    }
}
