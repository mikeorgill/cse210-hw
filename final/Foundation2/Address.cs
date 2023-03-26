public class Address
{
    public string streetAddress ="";
    public string city = "";
    public string state_province = "";
    public string country = "";
    public string postalCode = "";
    public string shippingLabel = "";

    public string address()
    {   
        if (country == "USA")
        {
            Console.Write($"{streetAddress}\n{city}, {state_province}  {postalCode}");
            shippingLabel = ($"{streetAddress}\n{city}, {state_province}  {postalCode}");
        }
        else
            Console.Write($"{streetAddress}\n{city}, {state_province}  {postalCode}\n{country}");
            shippingLabel = ($"{streetAddress}\n{city}, {state_province}  {postalCode}\n{country}");

        return shippingLabel;
        
    }

}