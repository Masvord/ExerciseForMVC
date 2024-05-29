using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			ViewResult result = View();
			return result;

			//return View();

		}

		public IActionResult Sayfa1()
		{
			return View();
		}


		public IActionResult Sayfa2()
		{
			return View();
		}

		public IActionResult Sayfa3()
		{
			return View();
		}
	}
}
