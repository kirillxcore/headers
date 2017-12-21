using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Headers.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Dictionary<string,string> h = new Dictionary<string, string>();

			foreach (var header in Request.Headers)
			{
				h.Add(header.ToString(), Request.Headers[header.ToString()]);
			}

			return View(h);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}