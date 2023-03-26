public class Customer
{
    public string customerName ="";
    
    Address customerAddress = new Address();

    public string custAddress()
    {
        return customerAddress.address();
    }

}