interface Document
{
    void open();
}

class PdfDocument implements Document
{
    public void open()
    {
        System.out.println("PDF Opened");
    }
}

class Factory
{
    static Document getDocument()
    {
        return new PdfDocument();
    }
}

class Main
{
    public static void main(String args[])
    {
        Document d =
        Factory.getDocument();

        d.open();
    }
}