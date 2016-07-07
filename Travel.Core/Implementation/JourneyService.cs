using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Travel.Core.Implementation
{
    //public class JourneyService : IJourneyService
    //{
    //    private readonly IJourney journey;


    //    public JourneyService(IJourney journeyDAL)
    //    {
    //        this.journey = journeyDAL;
    //    }

    //    public List<JourneyType> GetAllJourneyTypes()
    //    {
    //        return journey.GetJourneyTypes();
    //    }

    //    public List<JourneyType> CreateNewJourneyType(string newJourneyType)
    //    {
    //        var journeyType = new JourneyType();
    //        journeyType.Name = newJourneyType;
    //        journey.Add(journeyType);

    //        // return new list of journey types
    //        return journey.GetJourneyTypes();
    //    }

    //    public List<JourneyType> DeleteJourneyType(int id)
    //    {
    //        var entity = journey.Find(id);
    //        journey.Delete(entity);

    //        // return new list of journey types
    //        return journey.GetJourneyTypes();
    //    }

    //    public void EditJourneyType(int id, string journeyTypeName)
    //    {
    //        var journeyType = new JourneyType()
    //        {
    //            Id = id,
    //            Name = journeyTypeName
    //        };

    //        journey.Update(journeyType, id);
    //    }
    //}
}
