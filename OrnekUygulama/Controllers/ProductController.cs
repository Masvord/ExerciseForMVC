using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;


namespace OrnekUygulama.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			//var products = new List<Product>
			//{
			//	new Product { Id = 1, ProductName = "Product A", Quantity = 10 },
			//	new() { Id = 2, ProductName = "Product B", Quantity = 15 },
			//	new() { Id = 3, ProductName = "Product C", Quantity = 20 },
			//};

			//ViewResult productResult = View(products);
			//return productResult;
			//Model Bazlı Taşıma Sonu



			//ViewBag.products = products;
			//Dynamic ViewBag bazlı taşıma sonu



			//ViewData["products"] = products;
			//ViewData taşıma sonu



			//TempData["x"] = 5;
			//return RedirectToAction("Index2", "Product"); //İkinci product controller name
			//											  //Tempdata taşıma sonu


			return View();
		}

		//public IActionResult Index2()
		//{
		//	var v = TempData["x"];
		//	return View();
		//}



		public IActionResult GetProducts(int tryId)
		{
			Product product = new Product
			{
				Id = 1,
				ProductName = "Product A",
				Quantity = 10,

			};

			User user = new User
			{
				Id = 1,
				Name = "Fatih",
				LastName = "Kara"
			};

			//UserProduct userProduct = new UserProduct
			//{
			//	user = user,
			//	product = product
			//};

			//ViewResult getProductsresult = View(userProduct);

			//return getProductsresult;


			//TUPLE KULLANMA YOLUYLA YAPIMI

			var userProduct = (user, product);
			ViewResult getProductsresult = View(userProduct);
			return getProductsresult;


			//return View();

		}


		public IActionResult CreateProduct()
		{
			//Product product = new Product()
			//{
			//	Id = 1,
			//	ProductName = "Product A",
			//	Quantity = 10,
			//};

			//ViewResult result = View(product);
			//return result;
			return View();
		}

		[HttpPost]
		public IActionResult EditProduct(Product product)
		{
			return View();
		}




		public IActionResult ShowProduct() //AJAX Tabanlı Veri Yollama
		{
			ViewResult result = View();
			return result;
		}


		[HttpPost]
		public IActionResult ShowProduct(IFormCollection datas) //AJAX Tabanlı Veri Yollama
		{
			ViewResult result = View();
			return result;
		}






		//public IActionResult GetTupleProduct() //Tuple İşlemleri
		//{

		//	(Product, User) tuple = (new Product(), new User());
		//	return View(tuple);
		//}

		//[HttpPost]
		//public IActionResult TupleProduct([Bind(Prefix = "Item1")] Product product, [Bind(Prefix = "Item2")] User user /*IFormCollection datas*/)
		//{

		//	ViewResult result = View();
		//	return result;
		//}





		public IActionResult DataAnnotations()
		{
			return View();

		}

		[HttpPost]
		public IActionResult DataAnnotations(Product model)
		{
			if (!ModelState.IsValid)
			{
				var messages = ModelState.ToList();
				return View(model);
			}
			return View();
		}

	}
}