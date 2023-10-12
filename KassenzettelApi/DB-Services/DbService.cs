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
        string query = "CREATE TABLE TestTable(column1 int); ";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();     
    }
}
