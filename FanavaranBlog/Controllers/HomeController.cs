using FanavaranBlog.Models;
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
        Blog blog = new Blog()
        {
            Id = 1,
            Title = "اولین پست بلاگ فناوران",
            Description = "این اولین پست ما در آخرین جلسه کلاس طراحی سایت در دوره تابستان 1402 است. این پروژه در طول سال تحصیلی ادامه خواهد داشت.",
            BlogDate = DateTime.Now.ToString(),
            Img = "pic1.png",
            Source="توسط ادمین"
        };

        return View(blog);
    }
}
