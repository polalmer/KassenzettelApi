namespace KassenzettelApi.DB_Services;
using Classes;
using System.Data.SqlClient;

public class DbService
{
    private const string connection = "Data Source=YourServer;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword;";

    private readonly SqlConnection sqlConnection = new(connection);

    public void Add(Kassenzettel kassenzettel)
    {
        sqlConnection.Open();

        //Replace with real Table and Column
        SqlCommand insertCommand = new("INSERT INTO Users (Username, Email) VALUES (@Username, @Email)", sqlConnection);
        
        insertCommand.Parameters.Add(new SqlParameter("Username", "john_doe"));
        insertCommand.Parameters.Add(new SqlParameter("Email", "john@example.com"));

        insertCommand.ExecuteNonQuery();     
        
        sqlConnection.Close();
    }
}
