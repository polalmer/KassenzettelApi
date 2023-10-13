using KassenzettelApi.Classes;

namespace KassenzettelApi.DB_Services;

public class DbService
{
    private readonly KassenzettelDbContext context;

    public DbService(KassenzettelDbContext kassenzettelDbContext)
    {
        context = kassenzettelDbContext;
    }


    public void CreateKassenzettel(Kassenzettel kassenzettel)
    {
        context.Receipts.Add(kassenzettel);

        context.SaveChanges();
    }

    public Kassenzettel GetKassenzettel(int id)
    {
        Kassenzettel? zettel = context.Receipts.Where(x => x.Id == id).FirstOrDefault();

        return zettel;
    }
}
