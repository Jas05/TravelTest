using System.Collections.Generic;

namespace Travel.DAL.Interfaces
{
    public interface IJourney : IRepository<JourneyType>
    {
        List<JourneyType> GetJourneyTypes();
    }
}