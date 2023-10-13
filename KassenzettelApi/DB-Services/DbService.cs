using KassenzettelApi.Classes;
using Microsoft.EntityFrameworkCore;

namespace KassenzettelApi.DB_Services;

public class DbService
{
    private readonly KassenzettelDbContext context = new();

    public void CreateKassenzettel(Kassenzettel kassenzettel)
    {
        context.Receipts.Add(kassenzettel);

        context.SaveChanges();
    }

    public Kassenzettel? GetKassenzettel(int id)
    {
        Kassenzettel? zettel = context.Receipts.Where(x => x.Id == id).FirstOrDefault();
        return zettel;
    }

    public void CreateCustomer(Customer customer)
    {
        context.Customers.Add(customer);

        context.SaveChanges();
    }

    public Customer? GetCustomer(int id)
    {
        Customer? customer = context.Customers.Include(c => c.Kassenzettel).Where(x => x.Id == id).FirstOrDefault();
        return customer;
    }
}
