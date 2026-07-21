using System;

using System.Data;

using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string conString =
        "server=localhost;database=CommunityPortal;integrated security=true";

        SqlConnection con =
        new SqlConnection(conString);

        string q =
        "select * from Users";

        SqlDataAdapter da =
        new SqlDataAdapter(q, con);

        DataSet ds =
        new DataSet();

        da.Fill(ds);

        foreach(DataRow row in ds.Tables[0].Rows)
        {
            Console.WriteLine(row["full_name"]);
        }
    }
}