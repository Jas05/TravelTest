using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class OfferList
    {
        public List<Offer> Offers { get; set; }
    }

    public class Offer
    {
        public string ID { get; set; }
    }
}
