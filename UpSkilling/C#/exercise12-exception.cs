using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;

            int b = 0;

            Console.WriteLine(a / b);
        }
        catch(Exception e)
        {
            Console.WriteLine("Error");

            Console.WriteLine(e.Message);
        }
    }
}
