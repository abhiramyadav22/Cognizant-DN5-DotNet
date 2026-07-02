class Book
{
    int id;

    String title;

    Book(int id,String title)
    {
        this.id = id;

        this.title = title;
    }
}

class LibraryManagement
{
    public static void main(String args[])
    {
        Book arr[] =
        {
            new Book(1,"Java"),
            new Book(2,"Python")
        };

        String search = "Java";

        for(Book b : arr)
        {
            if(b.title.equals(search))
            {
                System.out.println("Book Found");
            }
        }
    }
}