using KassenzettelApi.Classes;
using System.Data.SqlClient;

namespace KassenzettelApi.DB_Services;

public static class DbService
{
    private const string connection = "Data Source=192.168.88.251/3306;Initial Catalog=FI23Kassenzettel;User ID=root;Password=AFBB1622;";

    private static readonly SqlConnection sqlConnection = new(connection);

    public static void Add(Kassenzettel kassenzettel)
    {
        sqlConnection.Open();

        //Replace with real Table and Column
        SqlCommand insertCommand = new("INSERT INTO Kassenzettel (Username, Email) VALUES (@Username, @Email)", sqlConnection);

        insertCommand.Parameters.Add(new SqlParameter("Username", "john_doe"));
        insertCommand.Parameters.Add(new SqlParameter("Email", "john@example.com"));

        insertCommand.ExecuteNonQuery();

        sqlConnection.Close();
    }
}
