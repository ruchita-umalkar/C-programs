// Database CRUD using ADO.NET 
using System;
using System.Data;
class Program
{
    static void Main()
    {
        // Example of ADO.NET code to perform CRUD operations
        // Note: This is a simplified example and may require additional setup (e.g., connection string, database schema)

        string connectionString = "your_connection_string_here";

        // Create (Insert)
        using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("INSERT INTO Items (Name, Price) VALUES (@Name, @Price)", connection);
            command.Parameters.AddWithValue("@Name", "Sample Item");
            command.Parameters.AddWithValue("@Price", 9.99m);
            command.ExecuteNonQuery();
        }

        // Read (Select)
        using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("SELECT Id, Name, Price FROM Items", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}");
                }
            }
        }

        // Update
        using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("UPDATE Items SET Price = @Price WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Price", 19.99m);
            command.Parameters.AddWithValue("@Id", 1); // Assuming we want to update the item with Id 1
            command.ExecuteNonQuery();
        }

        // Delete
        using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Items WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", 1); // Assuming we want to delete the item with Id 1
            command.ExecuteNonQuery();
        }
    }
}
