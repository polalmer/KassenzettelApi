using KassenzettelApi.Classes;
using MySql.Data.MySqlClient;

namespace KassenzettelApi.DB_Services;

public static class DbService
{
    private const string connectionString = "Server=192.168.88.251;Database=FI23Kassenzettel;Uid=jonas;Pwd=AFBB1622;";

    private static MySqlConnection connection = new(connectionString);

    public static void ConnectToDb()
    {
        connection.Open();
    }

    public static void Test()
    {
    }

    public static Kassenzettel CreateKassenzettel(Kassenzettel kassenzettel)
    {
        string query = $"INSERT INTO Receipt(Shop,CustomerId) VALUES ({kassenzettel.Shop},{kassenzettel.Customer});";
        MySqlCommand command = new(query, connection);
        command.ExecuteNonQuery();
        return kassenzettel;
    }
}
