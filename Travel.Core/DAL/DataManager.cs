using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Travel.Core.DomainEntities;

namespace Travel.Core.DAL
{
    public class DataManager
    {
        private readonly string executableLocation = HttpRuntime.AppDomainAppPath;

        public Booking GetBookingDetails(string bookingRef)
        {

            var bookinglist = DeserializeJson<BookingList>(Path.Combine(executableLocation + @"bin\DataModel\Booking.json"));
            return bookinglist.Bookings.FirstOrDefault(x => x.BookingRef == bookingRef);
        }

        //public List<Activity> GetActivities(string destinationID)
        //{

        //    var activitiesList = DeserializeJson<ActivityList>(Path.Combine(executableLocation + @"bin\DataModel\Activity.json"));
        //    return activitiesList.Activities.Where(x => x.DestinationID == destinationID).ToList();
        //}

        public List<Activity2> GetAllActivities()
        {

            //var activitiesList = DeserializeJson<ActivityList>(Path.Combine(executableLocation + @"bin\DataModel\Activity.json"));
            var activitiesList = Helper.GetActivites("alcudia", "2016-08-08", "2016-08-14");

            return activitiesList.Activities.ToList();
        }

        public Destination GetDestinationDetails(string destinationID)
        {

            var destinationList = DeserializeJson<DestinationList>(Path.Combine(executableLocation + @"bin\DataModel\Destination.json"));
            return destinationList.Destinations.FirstOrDefault(x => x.ID == destinationID);
        }

        public Flight GetFlightDetails(string flightId)
        {
            var destinationList = DeserializeJson<FlightList>(Path.Combine(executableLocation + @"bin\DataModel\Flight.json"));
            return destinationList.Flights.FirstOrDefault(x => x.ID == flightId);
        }

        public Resort GetResortDetails(string resortId)
        {
            var destinationList = DeserializeJson<ResortList>(Path.Combine(executableLocation + @"bin\DataModel\Resort.json"));
            return destinationList.Resorts.FirstOrDefault(x => x.ID == resortId);
        }

        public List<Notification> GetNotification(string bookingId)
        {
            var notificationList = DeserializeJson<NotificationList>(Path.Combine(executableLocation + @"bin\DataModel\Notification.json"));
            return notificationList.Notifications.Where(x=>x.NotificationType == "Booking").ToList();
        }

        public List<Notification> GetInResort(string bookingId)
        {
            var notificationList = DeserializeJson<NotificationList>(Path.Combine(executableLocation + @"bin\DataModel\Notification.json"));
            return notificationList.Notifications.Where(x=>x.NotificationType == "InResort").ToList();
        }

        private static T DeserializeJson<T>(string jsonfile)
        {
            StreamReader file = File.OpenText(jsonfile);
            JsonSerializer serializer = new JsonSerializer();
            T data = (T)serializer.Deserialize(file, typeof(T));
            return data;
        }
    }
}
