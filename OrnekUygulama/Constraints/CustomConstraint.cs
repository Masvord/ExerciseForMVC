
namespace OrnekUygulama.Constraints
{
	public class CustomConstraint : IRouteConstraint
	{
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			//throw new NotImplementedException();
			var routeValue = values[routeKey];
			return true; //Custom constraint kurallar çerçevesinde burada oluşturulur. 
		}
	}

}


