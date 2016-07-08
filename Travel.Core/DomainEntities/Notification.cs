using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class NotificationList
    {
        public List<Notification> Notifications { get; set; }
    }

    public class Notification
    {
        public string ID { get; set; }
        public string BookingID { get; set; }
        public string ResortID { get; set; }
        public string NotificationType { get; set; }
        public string NotificationText { get; set; }
        public string NotificationDate { get; set; }
    }
}
