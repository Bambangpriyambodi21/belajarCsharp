// C# Program with Query Command
using MySql.Data.MySqlClient;
using System;
internal class Program
{
    static void select()
    {
        string connectionString = "server=localhost;user=root;database=jobify;password=1m2h3b4y5W&";

        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        String query = "select * from manu";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            String data = reader.GetString(1);
            Console.WriteLine(data);
        }

        connection.Close();
    }

    static void insert()
    {
        string connectionString = "server=localhost;user=root;database=jobify;password=1m2h3b4y5W&";

        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        string query = "insert into manu values ('ok','ok',2,2)";
        MySqlCommand command = new MySqlCommand(query, connection);
        int reader = command.ExecuteNonQuery();

        if (reader > 0)
        {
            Console.WriteLine("data updated");
        }

        connection.Close();
    }

    private static void Main(string[] args)
    {
        select();
    }
}