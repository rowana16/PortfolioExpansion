﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioExpansion.Controllers
{
    public class JobController : Controller
    {
        // GET: JobStuff
        public ActionResult Partial(string viewSelect)
        {
            viewSelect = ("_" + viewSelect);
            return PartialView(viewSelect);
        }
    }
}