using System;

public class Customer

{

    // Customer's name (string)
    private string _name; 

    // Customer's address (Address class)
    private Address _shippingAddress; 

    // Constructor
    public Customer(string name, Address shippingAddress)

    {

        _name = name;
        _shippingAddress = shippingAddress;

    }


    // Getters and Setters
    public string Name

    {

        get => _name;
        set => _name = value;

    }

    public Address ShippingAddress

    {

        get => _shippingAddress;
        set => _shippingAddress = value;

    }

    // Method to retrieve the full shipping address
    public string GetShippingAddress()

    {

        return ShippingAddress.GetFullAddress();

    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    
    {

        return ShippingAddress.IsInUSA();

    }
    
}
