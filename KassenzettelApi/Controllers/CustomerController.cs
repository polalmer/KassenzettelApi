using Microsoft.AspNetCore.Mvc;
using KassenzettelApi.Classes;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [HttpGet("")]
    public string Get()
    {
        return "Hello world";
    }

    [HttpGet("Token")]
    public string GetToken(string username, string passwort)
    {
        return "Anmeldetoken";
    }

    [HttpPost("Kassenzettel")]
    public Kassenzettel CreateKassenZettel(Kassenzettel Kassenzettel)
    {
        //create Zettel in Db
        return Kassenzettel;
    }
}