using System.Collections.Generic;

namespace Travel_DAL.Interfaces
{
    public interface IJourney : IRepository<JourneyType>
    {
        List<JourneyType> GetJourneyTypes();
    }
}