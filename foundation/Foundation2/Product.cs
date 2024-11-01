using System;

public class Product

{

    private string _name;

    // Unique identifier for the product
    private string _productId; 

    // Price per unit
    private decimal _price; 

    // Quantity of the product
    private int _quantity; 

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)

    {

        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }

    // Getters and Setters
    public string Name

    {

        get => _name;
        set => _name = value;

    }


    public string ProductId

    {

        get => _productId;
        set => _productId = value;

    }

    public decimal Price

    {

        get => _price;
        set => _price = value;
        
    }

    public int Quantity

    {

        get => _quantity;
        set => _quantity = value;

    }

    // Calculate total cost for this product
    public decimal TotalCost()

    {

        return Price * Quantity;

    }
    
}
