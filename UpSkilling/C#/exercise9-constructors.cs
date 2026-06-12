using System;

class Event
{
    public Event()
    {
        Console.WriteLine("Constructor Called");
    }
}

class Program
{
    static void Main()
    {
        Event e = new Event();
    }
}