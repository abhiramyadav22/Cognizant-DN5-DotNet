class Festival
{
    void show()
    {
        System.out.println("Festival");
    }
}

class MusicFestival extends Festival
{
    void show()
    {
        System.out.println("Music Festival");
    }
}

class Main
{
    public static void main(String args[])
    {
        Festival f =
        new MusicFestival();

        f.show();
    }
}