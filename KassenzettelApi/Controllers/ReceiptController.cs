using Microsoft.AspNetCore.Mvc;
using KassenzettelApi.Classes;
using KassenzettelApi.DB_Services;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ReceiptController : ControllerBase
{
    private readonly DbService dbService;

    public ReceiptController(DbService dbService)
    {
        this.dbService = dbService;
    }

    [HttpGet("{id}")]
    public ActionResult<Kassenzettel> GetKassenzettel([FromRoute] int id)
    {
        Kassenzettel? kassenzettel = dbService.GetKassenzettel(id);    
        return Ok(kassenzettel);
    }
}