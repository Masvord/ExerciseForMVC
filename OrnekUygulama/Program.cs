using FluentValidation.AspNetCore;
using OrnekUygulama.Constraints;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint))); //Custom constraint Ekleme Yap�s�
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); //Default index �al��maz, hello world d�nd�r�r.


//�S�MLEND�R�LM�� ROTALAR - ROUTE CONSTRAINT - CUSTOM CONSTRA�NT
app.MapControllerRoute("DataAnnotations Y�nlendirmesi", "DataAnnotations", new { controller = "product", action = "DataAnnotations" });
app.MapControllerRoute("GetProduct Y�nlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });
app.MapControllerRoute("GetTupleProduct Y�nlendirmesi", "GetTupleProduct/{tryId:custom?}", new { controller = "product", action = "GetTupleProduct" });



app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseStaticFiles(); //wwwroot dosyas�na eri�mek i�in gereklidir.

app.Map("example-route", new OrnekUygulama.Handlers.ExampleHandler().Handler());

app.UseRouting();

app.Run();
