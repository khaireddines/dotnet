using Microsoft.AspNetCore.Mvc;

namespace ExerciceOne.Controllers;

public class PizzaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}