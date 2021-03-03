using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RelatedEntitiesAndInheritanceMVC.Models;
using RelatedEntitiesAndInheritanceMVC.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RelatedEntitiesAndInheritanceMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly InnCentreRepository _innCentreRepository;

        public HomeController(InnCentreRepository innCentreRepository)
        {
            _innCentreRepository = innCentreRepository;
        }

        public IActionResult Index()
        {
           var data= _innCentreRepository.GetAllBookingServers();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
