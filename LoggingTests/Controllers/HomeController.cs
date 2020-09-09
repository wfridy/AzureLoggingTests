using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingTests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggingTests.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeModel> _logger;

        public HomeController(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home Index requested and returned.");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            _logger.LogInformation("Home About requested and returned.");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            _logger.LogInformation("Home Contact requested and returned.");
            return View();
        }

        public IActionResult Error()
        {
            _logger.LogInformation("Home Error requested and returned.");
            return View();
        }
    }
}
