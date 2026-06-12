using System;

using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText(
        "event.txt",
        "Music Event");

        string data =
        File.ReadAllText("event.txt");

        Console.WriteLine(data);
    }
}