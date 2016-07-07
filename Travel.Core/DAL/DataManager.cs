using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Core.DomainEntities;

namespace Travel.Core.DAL
{
    public class DataManager
    {

        public Booking GetBookingDetails(string bookingRef, string surname)
        {
            var booking = Deserialize<List<Booking>>(Path.Combine(Environment.CurrentDirectory, @"DataModel\Booking.json"));
            return booking.FirstOrDefault(x => x.BookingRef.Equals(bookingRef) && x.Surname.Equals(surname));
        }

        private static T Deserialize<T>(string jsonfile)
        {
            StreamReader file = File.OpenText(jsonfile);
            JsonSerializer serializer = new JsonSerializer();
            T data = (T)serializer.Deserialize(file, typeof(T));
            return data;

        }


    }
}
