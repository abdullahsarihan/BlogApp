using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Areas.Admin.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
