using System;

class Event
{
    public virtual void Show()
    {
        Console.WriteLine("Event");
    }
}

class MusicEvent : Event
{
    public override void Show()
    {
        Console.WriteLine("Music Event");
    }
}

class Program
{
    static void Main()
    {
        Event e = new MusicEvent();

        e.Show();
    }
}