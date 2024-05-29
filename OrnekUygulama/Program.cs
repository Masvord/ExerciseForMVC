using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); //Default index çalýþmaz, hello world döndürür.

//Ýsimlendirilmiþ rotalar
app.MapControllerRoute("DataAnnotations Yönlendirmesi", "DataAnnotations", new { controller = "product", action = "dataannotations" });
app.MapControllerRoute("GetProduct Yönlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });


app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseStaticFiles(); //wwwroot dosyasýna eriþmek için gereklidir.

app.Map("example-route", new OrnekUygulama.Handlers.ExampleHandler().Handler());

app.UseRouting();

app.Run();
