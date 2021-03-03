using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Models
{
    public class InnCentreDbContext : DbContext
    { 
        public InnCentreDbContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
                  mb.Entity<Hotel>()
                 .HasMany(h => h.Rooms)
                 .WithOne(r => r.Hotel)
                 .HasForeignKey(r => r.HotelId);

            mb.Entity<PropertyBookingWebServerHasProperty>()
                .HasKey(p => new { p.PropertyId, p.PropertyBookingWebServerId });

            mb.Entity<PropertyBookingWebServerHasProperty>()
                .HasOne(p => p.Property)
                .WithMany(prop => prop.PropertyBookingWebServerHasProperties)
                .HasForeignKey(f => f.PropertyId);

            mb.Entity<PropertyBookingWebServerHasProperty>()
                .HasOne(p => p.PropertyBookingWebServer)
                .WithMany(prop => prop.PropertyBookingWebServerHasProperties)
                 .HasForeignKey(f => f.PropertyBookingWebServerId);

            mb.Entity<InnCentreBookingEngine>()
                .HasMany(In => In.PropertyBookingWebServers)
                .WithOne(property => property.InnCentreBookingEngine)
                .HasForeignKey(prop => prop.InnCentreBookingEngineId);

          mb.SeedData();
        }

        public DbSet<Property> Property { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<PropertyBookingWebServer> PropertyBookingWebServers { get; set; }
        public DbSet<PropertyBookingWebServerHasProperty> propertyBookingWebServerHasProperties { get; set; }
        public DbSet<InnRoad> InnRoads { get; set; }
        public DbSet<AirBnb>AirBnbs { get; set; }
        public DbSet<Expedia> Expedias { get; set; }
        public DbSet<InnCentreBookingEngine> InnCentreBookingEngines { get; set; }
    }
}
