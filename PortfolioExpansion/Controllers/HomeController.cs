using PortfolioExpansion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioExpansion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel();
            viewModel.ShowHeading = true;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel viewModel)
        {
            viewModel.ResetState();
            viewModel.SetState();

            return View(viewModel);
        }

        
    }
}