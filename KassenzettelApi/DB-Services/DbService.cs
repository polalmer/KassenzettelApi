using KassenzettelApi.Classes;
using System.Data.SqlClient;

namespace KassenzettelApi.DB_Services;

public static class DbService
{
    private const string connection = "Data Source=192.168.88.251/3306;Initial Catalog=FI23Kassenzettel;User ID=root;Password=AFBB1622;";

    private static readonly SqlConnection sqlConnection = new(connection);

    public static void ConnectToDb()
    {
        sqlConnection.Open();
    }

    /// <summary>
    ///     Legt einen neuen Eintrag in der Db für den Kassenzettel an
    /// </summary>
    public static void Create(Kassenzettel kassenzettel)
    {
        //Replace with real Table and Column
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Holt den Kassenzettel mit allen includes aus der Db
    /// </summary>
    public static Kassenzettel GetKassenzettel(int id)
    {
        SqlCommand command = new($"SELECT * FROM Kassenzettel WHERE Id = {id}", sqlConnection);

        var reader = command.ExecuteReader();

        reader.Read();

        Kassenzettel kassenzettel = new()
        {
            Id = reader.GetInt32(0),
            Shop = reader.GetString(1),
        };

        throw new NotImplementedException();

        return kassenzettel;
    }
}
