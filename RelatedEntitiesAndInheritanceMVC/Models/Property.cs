using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public abstract class Property
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

     public List<PropertyBookingWebServerHasProperty> PropertyBookingWebServerHasProperties { get; set;}
    }
}
