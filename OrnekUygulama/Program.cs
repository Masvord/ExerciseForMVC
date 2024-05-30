using FluentValidation.AspNetCore;
using OrnekUygulama.Constraints;
using OrnekUygulama.Handlers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint))); //Custom constraint Ekleme Yapısı
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();


app.UseStaticFiles(); //wwwroot dosyasına erişmek için gereklidir.

//app.MapGet("/", () => "Hello World!"); //Default index çalışmaz, hello world döndürür.


//İSİMLENDİRİLMİŞ ROTALAR - ROUTE CONSTRAINT - CUSTOM CONSTRAİNT
app.MapControllerRoute("DataAnnotations Yönlendirmesi", "DataAnnotations", new { controller = "product", action = "DataAnnotations" });
app.MapControllerRoute("GetProduct Yönlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });
app.MapControllerRoute("GetTupleProduct Yönlendirmesi", "GetTupleProduct/{tryId:custom?}", new { controller = "product", action = "GetTupleProduct" });

//HANDLERS
app.Map("example-route", new ExampleHandler().Handler());
app.Map("image/{imageName}", new ImageHandler().Handler(builder.Environment.WebRootPath)); //image/{imageName}?h=...

app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseRouting();

app.Run();
