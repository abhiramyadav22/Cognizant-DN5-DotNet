using System;

interface IMessage
{
    void Send();
}

class MockMessage : IMessage
{
    public void Send()
    {
        Console.WriteLine(
        "Message Sent");
    }
}

class Program
{
    static void Main()
    {
        IMessage message =
        new MockMessage();

        message.Send();
    }
}