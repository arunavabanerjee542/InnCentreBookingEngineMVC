using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public class PropertyBookingWebServerHasProperty
    {
        public  int PropertyBookingWebServerId { get; set; }
        public int PropertyId { get; set; }

        public PropertyBookingWebServer PropertyBookingWebServer { get; set; }
        public Property Property { get; set; }
    }
}
