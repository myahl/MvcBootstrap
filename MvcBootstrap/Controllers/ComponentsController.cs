using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrap.Controllers
{
	public class ComponentsController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Alerts()
		{
			ViewBag.Message = "Alerts go here.";

			return View();
		}
	}
}