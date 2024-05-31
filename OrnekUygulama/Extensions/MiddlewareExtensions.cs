using OrnekUygulama.MiddleWares;

namespace OrnekUygulama.Extensions
{
	static public class MiddlewareExtensions
	{
		public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder) //Çoğu middleware IApplicationBuilder'dan türer.
		{
			return applicationBuilder.UseMiddleware<HelloMiddleware>();
		}
	}
}
