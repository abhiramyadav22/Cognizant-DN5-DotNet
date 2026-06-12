using System;

class Program
{
    static void ShowEvent()
    {
        Console.WriteLine("Music Event");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        ShowEvent();

        int result = Add(10, 20);

        Console.WriteLine(result);
    }
}