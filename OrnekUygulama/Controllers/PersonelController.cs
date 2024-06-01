using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
	public class PersonelController : Controller
	{
		private readonly Personel _personelId;
		private readonly IServiceProvider _services;

		public PersonelController(Personel Id, IServiceProvider services)
		{
			_personelId = Id;
			_services = services;
		}

		public IActionResult Index()
		{
			var sp = _services.GetService<Personel>();

			Console.WriteLine("Personel Id: " + _personelId.Id);
			ViewData["Id"] = _personelId.Id;
			ViewBag.Id = sp.Id;
			return View(_personelId);
		}
	}
}
