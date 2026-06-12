using System;

using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string conString =
        "server=localhost;database=CommunityPortal;integrated security=true";

        SqlConnection con =
        new SqlConnection(conString);

        con.Open();

        string q =
        "insert into Users(full_name) values('Abhi')";

        SqlCommand cmd =
        new SqlCommand(q, con);

        cmd.ExecuteNonQuery();

        Console.WriteLine("Inserted");

        con.Close();
    }
}