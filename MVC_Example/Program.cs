var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC i projemize ekliyoruz

var app = builder.Build();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}"  //default route tanimlama
);

app.UseStaticFiles(); //wwwroot a erismek icin
app.Run(); 


//Controller : Projede verileri modelden alarak view e aktarir.
//Action : Controller icindeki fonksiyonlara denir.
//View : Sayfamizin tasarimini yaptigimiz yerdir.
//Razior - RazorView : Bir projeden html ve c# in birlikte kullanilarak bir frontend yapmasini saglamaktadir.
//wwwroot : js css ve jpeg gibi statik dosyalarin tutuldugu klasordur.
// builder.Build() : uygulama icindeki servisleri bagimliliklari tanimlar
//app.Run() : uygulamanin calismasini saglar bundan once gerekli middlewarelerde sorun yoksa uygulamayi calistirir.