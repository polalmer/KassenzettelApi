using Microsoft.AspNetCore.Mvc;

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
}