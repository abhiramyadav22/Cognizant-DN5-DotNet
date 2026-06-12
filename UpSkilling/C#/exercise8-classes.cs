using System;

class Event
{
    public string name = "Music Event";

    public void Show()
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main()
    {
        Event e = new Event();

        e.Show();
    }
}