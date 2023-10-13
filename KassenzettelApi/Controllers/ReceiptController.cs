using Microsoft.AspNetCore.Mvc;
using KassenzettelApi.Classes;
using KassenzettelApi.DB_Services;

namespace KassenzettelApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ReceiptController : ControllerBase
{
    [HttpPost]
    public ActionResult<Kassenzettel> CreateKassenzettel(Kassenzettel kassenzettel)
    {
        kassenzettel = DbService.CreateKassenzettel(kassenzettel);
        return Ok(kassenzettel);
    }

    [HttpGet("{id}")]
    public ActionResult<Kassenzettel> GetKassenzettel([FromRoute] int id)
    {
        //Get from DB
        throw new NotImplementedException();
        return Ok();
    }
}