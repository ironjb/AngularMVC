using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMvcSite.Areas.Game.Controllers
{
	public class HomeController : Controller
	{
		// GET: Game/Home
		public ActionResult Index()
		{
			return View();
		}
	}
}
