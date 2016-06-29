using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_DAL.Interfaces;
using Travel_DAL;
using Travel_BL.Interfaces;

namespace Travel_BL.Implementation
{
    public class JourneyService : IJourneyService
    {
        private readonly TravelEntities _travelContext;
        private readonly IJourney journey;


        public JourneyService(IJourney journeyDAL)
        {
            this.journey = journeyDAL;
        }

        public List<JourneyType> GetAllJourneyTypes()
        {
            return journey.GetJourneyTypes();
        }
    }
}
