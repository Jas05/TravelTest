using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class DestinationList
    {
        public List<Destination> Destinations { get; set; }
    }

    public class Destination
    {
        public string ID { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
