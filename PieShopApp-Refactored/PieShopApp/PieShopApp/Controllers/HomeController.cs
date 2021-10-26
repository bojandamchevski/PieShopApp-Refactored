using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PieShopApp.Models;
using PieShopApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPieService _pieService;

        public HomeController(ILogger<HomeController> logger, IPieService pieService)
        {
            _logger = logger;
            _pieService = pieService;
        }

        public IActionResult Index()
        {
            CultureInfo eur = CultureInfo.GetCultureInfo("es-ES");
            ViewBag.CurrencyConverter = eur;
            return View(_pieService.GetPiesOfTheWeek());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
