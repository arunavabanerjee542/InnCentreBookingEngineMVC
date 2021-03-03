using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public class Hotel : Property
    {
        public ICollection<Room> Rooms { get; set; }
        public int RoomCount { get; set; }

    }
}
