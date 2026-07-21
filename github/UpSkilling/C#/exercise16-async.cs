using System;

using System.Threading.Tasks;

class Program
{
    static async Task Show()
    {
        await Task.Delay(2000);

        Console.WriteLine("Event Started");
    }

    static async Task Main()
    {
        Console.WriteLine("Loading...");

        await Show();
    }
}