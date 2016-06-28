using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Travel_DAL
{
    class TravelContext : DbContext
    {
        public TravelContext() : base()
        {

        }
        public int MyProperty { get; set; }
    }
}
