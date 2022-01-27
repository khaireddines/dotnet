using Microsoft.AspNetCore.Mvc;

namespace ExerciceOne.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}