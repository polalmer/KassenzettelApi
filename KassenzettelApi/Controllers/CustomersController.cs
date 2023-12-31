﻿using KassenzettelApi.Classes;
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

        customer = dbService.CreateCustomer(customer);

        return Ok(customer);
    }

    [HttpGet()]
    public ActionResult<Customer> GetCustomer(int id)
    {
        return Ok(dbService.GetCustomer(id));
    }

    [HttpPost("{customer}/receipt")]
    public ActionResult<Kassenzettel> CreateKassenzettel([FromRoute] int customer, [FromBody] KassenzettelDto kassenzettel)
    {
        Kassenzettel receipt = new(kassenzettel);
        receipt = dbService.CreateKassenzettel(receipt);

        Customer? customerObj = dbService.GetCustomer(customer);
        if (customerObj is not null)
        {
            customerObj.Kassenzettel.Add(receipt);
            dbService.Save(customerObj);
        }

        return Ok(receipt);
    }
}
