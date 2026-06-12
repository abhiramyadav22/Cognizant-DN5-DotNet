using System;

class Person
{
    public void Show()
    {
        Console.WriteLine("Person Class");
    }
}

class Student : Person
{

}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.Show();
    }
}