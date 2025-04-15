using my_tracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace my_tracker.Controllers;

public class MangaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}