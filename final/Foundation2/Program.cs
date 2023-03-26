using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address address = new Address();
        Customer customer = new Customer();
        Order order = new Order();

        customer.customerName = "James";
        address.streetAddress = "123 ABC Road";
        address.city = "Murray";
        address.state_province = "UT";
        address.postalCode = "84121";
        address.country = "USA";
        customer.custAddress();
        

    }
}