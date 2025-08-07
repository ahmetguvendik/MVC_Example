using Microsoft.AspNetCore.Mvc;

namespace MVC_Example.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}