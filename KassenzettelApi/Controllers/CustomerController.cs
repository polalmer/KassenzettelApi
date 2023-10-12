using Microsoft.AspNetCore.Mvc;
using KassenzettelApi.Classes;
using KassenzettelApi.DB_Services;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly DbService _DbService;

    public CustomerController(DbService dbService)
    {
        _DbService = dbService;
    }


    [HttpPost("Kassenzettel")]
    public ActionResult<Kassenzettel> CreateKassenZettel(Kassenzettel Kassenzettel)
    {
        //create Zettel in Db
        _DbService.Add(Kassenzettel);
        return Ok(Kassenzettel);
    }

    [HttpGet("Kassenzettel")]
    public ActionResult<Kassenzettel> GetKassenzettel([FromBody] int id)
    {
        //Get from DB
        throw new NotImplementedException();
        return Ok();
    }
}