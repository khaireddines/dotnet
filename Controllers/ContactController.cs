using ExerciceOne.Models;
using ExerciceOne.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceOne.Controllers;
[ApiController]
[Route("[controller]")]
public class ContactController : Controller
{
    private readonly ContactService _contactService;
    
    public ContactController(ContactService contactService)
    {
        _contactService = contactService;
    }
    [HttpGet]
    public async Task<List<Contact>> Get() =>
        await _contactService.GetAsync();

    [HttpGet("All")]
    public List<Contact> GetAll() =>
        _contactService.GetAll();

}