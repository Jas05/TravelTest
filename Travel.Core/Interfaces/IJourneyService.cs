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
    }
}
