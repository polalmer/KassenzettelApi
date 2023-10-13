using KassenzettelApi.Classes;
using Microsoft.EntityFrameworkCore;

namespace KassenzettelApi.DB_Services;

public class KassenzettelDbContext : DbContext
{
    private const string connectionString = "Server=192.168.88.251; User ID=jonas; Password=AFBB1622; Database=FI23Kassenzettel";

    public DbSet<Kassenzettel> Receipts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
