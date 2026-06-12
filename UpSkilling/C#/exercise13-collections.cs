using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> events =
        new List<string>();

        events.Add("Music");

        events.Add("Sports");

        foreach(string e in events)
        {
            Console.WriteLine(e);
        }
    }
}