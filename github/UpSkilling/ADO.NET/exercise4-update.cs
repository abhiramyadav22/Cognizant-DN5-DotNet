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
        "update Users set full_name='Rahul' where user_id=1";

        SqlCommand cmd =
        new SqlCommand(q, con);

        cmd.ExecuteNonQuery();

        Console.WriteLine("Updated");

        con.Close();
    }
}