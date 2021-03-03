using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public static class Seed
    {

        public static  void  SeedData(this ModelBuilder mb)
        {
            mb.Entity<Hotel>().HasData(
                new Hotel() { PropertyId= 1,
                    Address="USA", Description="5 star rated hotel",
                Name="Hotel Chai Palace"},

                  new Hotel()
                  {
                      PropertyId = 2,
                      Address = "USA",
                      Description = "4 star rated hotel",
                      Name = "Hotel Taj Palace"
                  }

                );


            mb.Entity<Room>().HasData(
                new Room() { RoomId=1 , HotelId=1, IsAvailable=true},
                 new Room() { RoomId = 2, HotelId = 1, IsAvailable = true },
                  new Room() { RoomId = 3, HotelId = 1, IsAvailable = true },
                   new Room() { RoomId = 4, HotelId = 2, IsAvailable = true }
                );

            mb.Entity<InnCentreBookingEngine>()
                .HasData(
                new InnCentreBookingEngine()
                {
                    InnCentreBookingEngineId = 1,
                }
                );


            mb.Entity<InnRoad>().HasData(
                new InnRoad()
                {
                    PropertyBookingWebServerId = 1,
                    InnCentreBookingEngineId = 1
                }
                ); 

            mb.Entity<AirBnb>().HasData(
                new AirBnb() { PropertyBookingWebServerId = 2,
                InnCentreBookingEngineId =1}
                );

            mb.Entity<Expedia>().HasData(
                new Expedia() { PropertyBookingWebServerId = 3,
                InnCentreBookingEngineId = 1}
                );


              mb.Entity<PropertyBookingWebServerHasProperty>()
                .HasData(
                new PropertyBookingWebServerHasProperty()
                {
                    PropertyBookingWebServerId = 1,
                    PropertyId = 1
                },

                new PropertyBookingWebServerHasProperty()
                {
                    PropertyBookingWebServerId = 1,
                    PropertyId = 2                   
                },

                new PropertyBookingWebServerHasProperty()
                {
                    PropertyBookingWebServerId = 2,
                    PropertyId = 2
                }
                ) ;


            





        }


    }
}
