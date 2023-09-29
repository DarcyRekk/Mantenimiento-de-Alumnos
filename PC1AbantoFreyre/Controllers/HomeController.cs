using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1AbantoFreyre.Database.AlumnosContext;
using PC1AbantoFreyre.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PC1AbantoFreyre.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlumnosContext _alumnosContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AlumnosContext alumnosContext)
        {
            _logger = logger;
            _alumnosContext = alumnosContext;
        }

        public IActionResult Index()
        {
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
