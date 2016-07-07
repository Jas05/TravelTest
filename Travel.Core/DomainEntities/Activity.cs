using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class ActivityList
    {
        public List<Activity> Activities { get; set; }
    }

    public class Activity
    {
        public string ID { get; set; }
        public string DestinationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PriceGBP { get; set; }
        public string BookingURL { get; set; }
        public string ActivityType { get; set; }
    }
}
