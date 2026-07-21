using System;

class Program
{
    static void Main()
    {
        string[] events =
        {
            "Music",
            "Sports",
            "Workshop"
        };

        for(int i = 0; i < events.Length; i++)
        {
            Console.WriteLine(events[i]);
        }
    }
}