using Microsoft.AspNetCore.Mvc;

namespace aspnetcoredev.Controllers;

public class MovieController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int id = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["Id"] = id;
        return View();
    }
}