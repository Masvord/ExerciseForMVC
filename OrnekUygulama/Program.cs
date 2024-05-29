using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();



//app.MapGet("/", () => "Hello World!"); //Default index �al��maz, hello world d�nd�r�r.

//�simlendirilmi� rotalar
app.MapControllerRoute("DataAnnotations Y�nlendirmesi", "DataAnnotations", new { controller = "product", action = "dataannotations" });
app.MapControllerRoute("GetProduct Y�nlendirmesi", "getProducts/{tryId:int:length(1)?}", new { controller = "product", action = "GetProducts" });


app.MapDefaultControllerRoute();

app.UseHttpsRedirection();

app.UseStaticFiles(); //wwwroot dosyas�na eri�mek i�in gereklidir.

app.Map("example-route", new OrnekUygulama.Handlers.ExampleHandler().Handler());

app.UseRouting();

app.Run();
