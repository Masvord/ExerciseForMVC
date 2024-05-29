using FluentValidation.AspNetCore;
using OrnekUygulama.Constraints;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint))); //Custom constraint Ekleme Yapısı
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); //Default index çalışmaz, hello world döndürür.


//İSİMLENDİRİLMİŞ ROTALAR - ROUTE CONSTRAINT - CUSTOM CONSTRAİNT
app.MapControllerRoute("DataAnnotations Yönlendirmesi", "DataAnnotations", new { controller = "product", action = "DataAnnotations" });
app.MapControllerRoute("GetProduct Yönlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });
app.MapControllerRoute("GetTupleProduct Yönlendirmesi", "GetTupleProduct/{tryId:custom?}", new { controller = "product", action = "GetTupleProduct" });



app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseStaticFiles(); //wwwroot dosyasına erişmek için gereklidir.

app.Map("example-route", new OrnekUygulama.Handlers.ExampleHandler().Handler());

app.UseRouting();

app.Run();
