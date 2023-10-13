using KassenzettelApi.Classes;
using Microsoft.EntityFrameworkCore;

namespace KassenzettelApi.DB_Services;

public class DbService
{
    private readonly KassenzettelDbContext context = new();

    public Kassenzettel CreateKassenzettel(Kassenzettel kassenzettel)
    {
        context.Receipts.Add(kassenzettel);

        context.SaveChanges();

        return kassenzettel;
    }

    public Kassenzettel? GetKassenzettel(int id)
    {
        Kassenzettel? zettel = context.Receipts.Include(x => x.Items).Where(x => x.Id == id).FirstOrDefault();
        return zettel;
    }

    public Customer CreateCustomer(Customer customer)
    {
        context.Customers.Add(customer);

        context.SaveChanges();

        return customer;
    }

    public Customer? GetCustomer(int id)
    {
        Customer? customer = context.Customers.Include(c => c.Kassenzettel)
            .ThenInclude(r => r.Items).Where(x => x.Id == id).FirstOrDefault();
        return customer;
    }

    public void Save(Customer customer)
    {
        context.SaveChanges();
    }
}
