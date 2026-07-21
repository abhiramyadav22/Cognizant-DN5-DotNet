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

        Console.WriteLine("Connection Open");

        con.Close();
    }
}