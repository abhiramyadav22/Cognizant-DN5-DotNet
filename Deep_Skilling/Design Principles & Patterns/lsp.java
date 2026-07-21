class Bird
{
    void sound()
    {
        System.out.println("Bird Sound");
    }
}

class Sparrow extends Bird
{
    void sound()
    {
        System.out.println("Sparrow Sound");
    }
}

class Main
{
    public static void main(String args[])
    {
        Bird b =
        new Sparrow();

        b.sound();
    }
}