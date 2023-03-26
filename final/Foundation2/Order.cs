public class Order
{
    List<string> productList = new List<string>();
    List<string> customerList = new List<string>();
    public int orderCost;
    public int totalOrderCost;
    public int calulateOrderCost(List<string> orderList)
    {
        
        foreach (string product in orderList)
        {
            
            int itemCost = product[1];
            Console.WriteLine($"Product: {product}\nItem Cost: {itemCost}");
            orderCost = orderCost + itemCost;
            Console.WriteLine(orderCost);
        }

        return orderCost; 
    }

    public int calulateTotalCost(int order, int shipping)
    {   
        return totalOrderCost = order+shipping;
    }
    public void packingLabel()
    {
        Console.WriteLine();
    }

    public void shippingLabel()
    {
        Console.WriteLine();
    }
}