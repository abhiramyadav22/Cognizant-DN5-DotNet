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
        "select * from Users";

        SqlCommand cmd =
        new SqlCommand(q, con);

        SqlDataReader dr =
        cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["full_name"]);
        }

        con.Close();
    }
}
