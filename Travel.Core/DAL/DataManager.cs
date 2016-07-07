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

        public Booking GetBookingDetails(string bookingRef, string surname)
        {

            var bookinglist = DeserializeJson<BookingList>(Path.Combine(executableLocation + @"bin\DataModel\Booking.json"));
            return bookinglist.Booking.FirstOrDefault(x => x.BookingRef.Equals(bookingRef) && x.Surname.Equals(surname));
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
