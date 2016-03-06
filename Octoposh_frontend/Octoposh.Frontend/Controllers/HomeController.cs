using Octoposh.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Octoposh.Frontend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Gallery = new Gallery();
            var model = Gallery.GetEntries();
            return View(model);
        }
    }
}