using Microsoft.EntityFrameworkCore;
using RelatedEntitiesAndInheritanceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Repository
{
    public class InnCentreRepository : IInnCentreRepository
    {
        private InnCentreDbContext _context;
        public InnCentreRepository(InnCentreDbContext context)
        {
            _context = context;
        }

        public IQueryable<PropertyBookingWebServer> GetAllBookingServers()
        {
            return _context.PropertyBookingWebServers
                 .Include(p => p.PropertyBookingWebServerHasProperties);
               
                
                
               
              
        }
    }
}
