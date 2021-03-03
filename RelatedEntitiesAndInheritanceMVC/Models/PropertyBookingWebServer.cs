using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public abstract class PropertyBookingWebServer
    {
        public int PropertyBookingWebServerId { get; set; }
        public List<PropertyBookingWebServerHasProperty>
            PropertyBookingWebServerHasProperties { get; set; }

        public int InnCentreBookingEngineId { get; set; }
        public InnCentreBookingEngine InnCentreBookingEngine { get; set; }

    }
}
