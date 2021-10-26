using Microsoft.AspNetCore.Mvc;
using PieShopApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopApp.Controllers
{
    public class PieController : Controller
    {
        private IPieService _pieService;
        private ICategoryService _categoryService;

        public PieController(IPieService pieService, ICategoryService categoryService)
        {
            _pieService = pieService;
            _categoryService = categoryService;
        }
        public IActionResult List(string category)
        {
            CultureInfo eur = CultureInfo.GetCultureInfo("es-ES");
            ViewBag.CurrencyConverter = eur;
            return View(_categoryService.GetPieList(category));
        }

        public IActionResult Details(int? id)
        {
            CultureInfo eur = CultureInfo.GetCultureInfo("es-ES");
            ViewBag.CurrencyConverter = eur;
            var pie = _pieService.GetPieById(id.Value);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
