using RelatedEntitiesAndInheritanceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Repository
{
    public interface IInnCentreRepository
    {
        IQueryable<PropertyBookingWebServer> GetAllBookingServers();
    }
}
