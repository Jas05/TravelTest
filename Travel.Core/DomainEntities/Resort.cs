using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class ResortList
    {
        public List<Resort> Resorts { get; set; }
    }

    public class Resort
    {
        public string ID { get; set; }

        public string ResortName { get; set; }
    }
}
