using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public class InnCentreBookingEngine
    {
        public int InnCentreBookingEngineId { get; set; }
        public ICollection<PropertyBookingWebServer> PropertyBookingWebServers { get; set; }
    }
}
