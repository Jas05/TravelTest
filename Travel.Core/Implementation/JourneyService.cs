using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DAL.Interfaces;
using Travel.DAL;
using Travel.Core.Interfaces;

namespace Travel.Core.Implementation
{
    public class JourneyService : IJourneyService
    {
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
