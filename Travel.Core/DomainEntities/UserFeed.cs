using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class UserFeedList
    {
        public List<UserFeed> UserFeeds { get; set; }
    }

    public class UserFeed
    {
        public string ID { get; set; }
        public string DestinationID { get; set; }
    }
}
