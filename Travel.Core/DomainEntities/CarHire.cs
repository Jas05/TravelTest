using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class CarHire
    {
        public string CarCount { get; set; }
        public CarInfoList CarInfoList { get; set; }
    }

    public class CarDoorCount
    {
        public string Min { get; set; }
        public string Max { get; set; }
    }

    public class Distance
    {
        public string UnitCount { get; set; }
        public string Unit { get; set; }
    }

    public class GeoLocation
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Location
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string LocationID { get; set; }
        public string ShuttleCategory { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public Distance Distance { get; set; }
        public GeoLocation GeoLocation { get; set; }
    }

    public class PickupInfo
    {
        public string DateTime { get; set; }
        public Location Location { get; set; }
    }

    public class Distance2
    {
        public string UnitCount { get; set; }
        public string Unit { get; set; }
    }

    public class GeoLocation2
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Location2
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string LocationID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public Distance2 Distance { get; set; }
        public GeoLocation2 GeoLocation { get; set; }
    }

    public class DropOffInfo
    {
        public string DateTime { get; set; }
        public Location2 Location { get; set; }
    }

    public class Capacity
    {
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string SmallLuggageCount { get; set; }
        public string LargeLuggageCount { get; set; }
    }

    public class BaseRate
    {
        public string Value { get; set; }
        public string Currency { get; set; }
    }

    public class DailyRate
    {
        public string Value { get; set; }
        public string Currency { get; set; }
    }

    public class TotalRate
    {
        public string Value { get; set; }
        public string Currency { get; set; }
    }

    public class Price
    {
        public BaseRate BaseRate { get; set; }
        public DailyRate DailyRate { get; set; }
        public TotalRate TotalRate { get; set; }
    }

    public class FreeDistance
    {
        public string UnitCount { get; set; }
    }

    public class Mileage
    {
        public FreeDistance FreeDistance { get; set; }
    }

    public class CarInfo
    {
        public string CarMakeModel { get; set; }
        public string CarClass { get; set; }
        public CarDoorCount CarDoorCount { get; set; }
        public string TransmissionDriveCode { get; set; }
        public string FuelACCode { get; set; }
        public string FuelInfo { get; set; }
        public string ACRISSCategoryCode { get; set; }
        public string ACRISSTypeCode { get; set; }
        public string ACRISSTransmissionDriveCode { get; set; }
        public string ACRISSFuelACCode { get; set; }
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string PIID { get; set; }
        public PickupInfo PickupInfo { get; set; }
        public DropOffInfo DropOffInfo { get; set; }
        public Capacity Capacity { get; set; }
        public string DetailsUrl { get; set; }
        public string RatePeriodCode { get; set; }
        public Price Price { get; set; }
        public string PrePay { get; set; }
        public string CreditCardRequired { get; set; }
        public Mileage Mileage { get; set; }
        public string ThumbnailUrl { get; set; }
    }

    public class CarInfoList
    {
        public List<CarInfo> CarInfo { get; set; }
    }

}

