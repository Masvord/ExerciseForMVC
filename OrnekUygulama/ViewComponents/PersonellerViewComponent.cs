using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.ViewComponents
{
	public class PersonellerViewComponent : ViewComponent
	{

		public IViewComponentResult Invoke(int id)
		{
			List<Personel> datas = new List<Personel>
			{
				new Personel { Name = "Fatih", Surname = "KARA" },
				new Personel { Name = "Murat Özkan", Surname = "KAYA" },
				new Personel { Name = "Doğukan", Surname = "MUSLUKÇU" },
			};
			return View(datas);
		}
	}
}

