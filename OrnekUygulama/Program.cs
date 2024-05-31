using FluentValidation.AspNetCore;
using OrnekUygulama.Constraints;
using OrnekUygulama.Extensions;
using OrnekUygulama.Handlers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint))); //Custom constraint Ekleme Yapýsý
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();


app.UseStaticFiles(); //wwwroot dosyasýna eriþmek için gereklidir.

//app.MapGet("/", () => "Hello World!"); //Default index çalýþmaz, hello world döndürür.


//ÝSÝMLENDÝRÝLMÝÞ ROTALAR - ROUTE CONSTRAINT - CUSTOM CONSTRAÝNT
app.MapControllerRoute("DataAnnotations Yönlendirmesi", "DataAnnotations", new { controller = "product", action = "DataAnnotations" });
app.MapControllerRoute("GetProduct Yönlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });
app.MapControllerRoute("GetTupleProduct Yönlendirmesi", "GetTupleProduct/{tryId:custom?}", new { controller = "product", action = "GetTupleProduct" });


//HANDLERS
app.Map("example-route", new ExampleHandler().Handler());
app.Map("image/{imageName}", new ImageHandler().Handler(builder.Environment.WebRootPath)); //image/{imageName}?h=...


//EXTENSÝON Ýle EKlenen MIDDLEWARE
app.UseHello(); //Default middleware "RUN"dýr.


app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseRouting();

app.Run();
