public class Product
{
    private string productName;
    private int productId;
    private int productPrice;
    private int quantity;

    public int productCost()
    {   
        int productTotal = productPrice * quantity;
        return productTotal;
    }
}