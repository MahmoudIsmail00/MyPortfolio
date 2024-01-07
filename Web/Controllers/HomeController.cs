using Core.Entities;
using Core.Intrfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolio;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<PortfolioItem> portfolio)
        {
            _owner = owner;
            _portfolio = portfolio;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(viewModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
