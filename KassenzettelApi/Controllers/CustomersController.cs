using KassenzettelApi.Classes;
using KassenzettelApi.DB_Services;
using Microsoft.AspNetCore.Mvc;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly DbService dbService;

    public CustomerController(DbService dbService)
    {
        this.dbService = dbService;
    }


    [HttpPost]
    public ActionResult<Customer> CreateCustomer(string vorname, string nachname, string Nutzername, string password)
    {
        Customer customer = new()
        {
            Vorname = vorname,
            Nachname = nachname,
            Kassenzettel = new(),
            Nutzername = Nutzername,
            Passwort = password
        };

        dbService.CreateCustomer(customer);

        return Ok(customer);
    }

    [HttpGet()]
    public ActionResult<Customer> GetCustomer(int id)
    {
        return Ok(dbService.GetCustomer(id));
    }
}
