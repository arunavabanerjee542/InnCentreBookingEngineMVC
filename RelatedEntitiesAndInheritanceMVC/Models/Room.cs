using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public bool IsAvailable { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
