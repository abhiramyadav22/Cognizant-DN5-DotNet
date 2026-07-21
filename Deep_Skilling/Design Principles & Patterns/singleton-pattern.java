class Logger
{
    private static Logger obj;

    private Logger()
    {

    }

    static Logger getInstance()
    {
        if(obj == null)
        {
            obj = new Logger();
        }

        return obj;
    }

    void show()
    {
        System.out.println("Single Object");
    }
}

class Main
{
    public static void main(String args[])
    {
        Logger l =
        Logger.getInstance();

        l.show();
    }
}