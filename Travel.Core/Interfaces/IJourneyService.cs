using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.DAL;

namespace Travel.Core.Interfaces
{
    public interface IJourneyService
    {
        List<JourneyType> GetAllJourneyTypes();

        List<JourneyType> CreateNewJourneyType(string journeyType);

        List<JourneyType> DeleteJourneyType(int id);

        void EditJourneyType(int id, string journeyTypeName);
    }
}
