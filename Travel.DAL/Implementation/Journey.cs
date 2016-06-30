using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Travel.DAL.Interfaces;

namespace Travel.DAL.Implementation
{
    public class Journey : RepositoryBase<JourneyType>, IJourney
    {
        private TravelEntities _travelContext;

        public Journey(TravelEntities context) : base(context)
        {
            _travelContext = context;
        }

        public JourneyType GetById(int id)
        {
            return this.GetByID(a => a.Id == id);
        }

        public List<JourneyType> GetJourneyTypes()
        {
            return this.GetAll().ToList();
        }
    }
}
