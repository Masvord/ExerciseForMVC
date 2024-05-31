namespace OrnekUygulama.MiddleWares
{
	public class HelloMiddleware //Middleware'ler, HTTP isteği ile yanıt arasına girip işlemler gerçekleştiren bileşenlerdir.
	{
		RequestDelegate _next; //HTTP isteğini işleyen bir delegedir.

		public HelloMiddleware(RequestDelegate next)
		{
			_next = next;
		}


		public async Task Invoke(HttpContext context) //Bu metot, middleware'in ana işlevini gerçekleştirir. Invoke metodu HTTP isteğini işler. 
		{
			Console.WriteLine("MiddleWare is working.");
			await _next.Invoke(context); //Sonraki middleware'in Invoke metodunu çağırır. Bu, middleware zincirindeki sonraki adıma geçiş yapılmasını sağlar. 
			Console.WriteLine("MiddleWare done.");
		}

		//Bu middleware, herhangi bir HTTP isteği geldiğinde çalışacak ve konsola iki mesaj yazdıracak:
		//Biri middleware'in çalıştığını belirten bir mesaj ve diğeri middleware'in işini tamamladığını belirten bir mesaj.
		//Bu, middleware zincirindeki bu adımdan sonraki işlemlerin gerçekleşmesini sağlar.
	}
}
