using Microsoft.AspNetCore.Mvc;

namespace FanavaranBlog.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Post()
    {
        return View();
    }
}
