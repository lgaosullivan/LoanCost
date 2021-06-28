using LoanCost.Interfaces;
using LoanCost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoanCost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICreateHomeLoan _createHomeLoan;

        public HomeController(ICreateHomeLoan createHomeLoan)
        {
            _createHomeLoan = createHomeLoan;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MonthlyPaybackPlan monthlyPaybackPlan)
        {
            var plans = _createHomeLoan.Create(monthlyPaybackPlan);
            return View("Details", plans);
        }

        public IActionResult Details(IEnumerable<LoanCost.Models.MonthlyPaybackPlan> plans)
        {
            return View(plans);
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
