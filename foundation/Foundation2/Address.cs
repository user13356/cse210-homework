using System;

public class Address

{
    // Street address
    private string _street; 

    // City
    private string _city; 

    // Province/State
    private string _state; 

    // Country
    private string _country; 

    // Constructor
    public Address(string street, string city, string state, string country)

    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    // Getters and Setters
    public string Street

    {

        get => _street;
        set => _street = value;

    }

    public string City

    {

        get => _city;
        set => _city = value;

    }

    public string State

    {

        get => _state;
        set => _state = value;

    }

    public string Country

    {

        get => _country;
        set => _country = value;

    }

    // Method to get the full address as a string
    public string GetFullAddress()

    {

        return $"{Street}, {City}, {State}, {Country}";

    }

    // Method to check if the address is in the USA
    public bool IsInUSA()

    {

        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    }
    
}
