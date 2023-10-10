using Microsoft.AspNetCore.Mvc;

namespace Celilcavus.controller;

public class HomeController : Controller
{
    public IActionResult index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Remove(int id)
    {
        
        return RedirectToAction(nameof(index));
    }
}