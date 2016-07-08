using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class ActivityList
    {
        public List<Activity2> Activities { get; set; }
    }

    public class Activity
    {
        public string ID { get; set; }
        public string DestinationID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PriceGBP { get; set; }
        public string BookingURL { get; set; }
        public string ActivityType { get; set; }
    }

    public class Activity2
    {
        public string id { get; set; }
    public string title { get; set; }
    public string imageUrl { get; set; }
    public string largeImageURL { get; set; }
    public string fromPrice { get; set; }
    public string fromPriceLabel { get; set; }
    public string fromOriginalPrice { get; set; }
    public string fromOriginalPriceValue { get; set; }
    public string duration { get; set; }
    public string fromPriceTicketType { get; set; }
    public string freeCancellation { get; set; }
    public string discountPercentage { get; set; }
    public List<string> categories { get; set; }
    public string latLng { get; set; }
    public string redemptionType { get; set; }
    public string supplierName { get; set; }
    public string recommendationScore { get; set; }
    public string discountType { get; set; }
    public string shortDescription { get; set; }
}




}
