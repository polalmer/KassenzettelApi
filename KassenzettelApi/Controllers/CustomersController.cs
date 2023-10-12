using KassenzettelApi.Classes;
using KassenzettelApi.DB_Services;
using Microsoft.AspNetCore.Mvc;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    public Customer CreateCustomer([FromBody] Customer customer)
    {
        throw new NotImplementedException();
        return customer;
    }
}
