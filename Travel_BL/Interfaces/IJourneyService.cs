using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_DAL;

namespace Travel_BL.Interfaces
{
    interface IJourneyService
    {
        List<JourneyType> GetAllJourneyTypes();
    }
}
