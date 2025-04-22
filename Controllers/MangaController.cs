using my_tracker.Models;
using Microsoft.AspNetCore.Mvc;
using my_tracker.Data;

namespace my_tracker.Controllers;

public class MangaController : Controller
{
    private readonly ApplicationDbContext _context;

    public MangaController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var mangas = _context.Mangas.ToList();
        return View(mangas);
    }
}