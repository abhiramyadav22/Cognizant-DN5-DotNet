class Order
{
    int orderId;

    double totalPrice;

    Order(int orderId,double totalPrice)
    {
        this.orderId = orderId;

        this.totalPrice = totalPrice;
    }
}

class SortingOrders
{
    public static void main(String args[])
    {
        Order arr[] =
        {
            new Order(1,5000),
            new Order(2,2000),
            new Order(3,7000)
        };

        for(int i=0;i<arr.length;i++)
        {
            for(int j=0;j<arr.length-1;j++)
            {
                if(arr[j].totalPrice >
                   arr[j+1].totalPrice)
                {
                    Order temp = arr[j];

                    arr[j] = arr[j+1];

                    arr[j+1] = temp;
                }
            }
        }

        for(Order o : arr)
        {
            System.out.println(o.totalPrice);
        }
    }
}
