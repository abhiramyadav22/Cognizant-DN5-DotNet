import java.util.HashMap;

class Product
{
    int productId;

    String productName;

    int quantity;

    double price;

    Product(int productId,
            String productName,
            int quantity,
            double price)
    {
        this.productId = productId;
        this.productName = productName;
        this.quantity = quantity;
        this.price = price;
    }
}

class InventoryManagement
{
    public static void main(String args[])
    {
        HashMap<Integer, Product> map =
        new HashMap<>();

        Product p1 =
        new Product(1,"Mouse",10,500);

        map.put(p1.productId,p1);

        System.out.println("Product Added");

        map.remove(1);

        System.out.println("Product Deleted");
    }
}