using System;
using System.Collections.Generic;

public class Order

{
    private List<Customer> _customers = new List<Customer>();
    private List<Product> _products = new List<Product>();

    // Method to add a customer to the order
    public void AddCustomer(Customer customer)

    {

        _customers.Add(customer);
        
    }

    // Method to add a product to the order
    public void AddProduct(Product product)

    {

        _products.Add(product);

    }


    // Calculate total cost of the order
    public decimal CalculateTotalCost()

    {

        decimal total = 0;
        foreach (var product in _products)

        {
            // Add each product's total cost
            total += product.TotalCost(); 

        }

        // Add shipping cost
        total += CalculateShippingCost(); 
        return total;

    }

    // Calculate shipping cost based on customer location
    private decimal CalculateShippingCost()

    {

        decimal shippingCost = 0;
        foreach (var customer in _customers)
        {
            if (customer.LivesInUSA())
            {
                shippingCost += 10m; // Shipping to USA
            }
            else
            {
                shippingCost += 40m; // Shipping to other countries
            }
        }
        return shippingCost;

    }

    // Generate a package label for the order
    public string GeneratePackageLabel()

    {

        var label = "Package Label:\n";
        foreach (var customer in _customers)

        {

            label += $"{customer.Name}\n{customer.GetShippingAddress()}\n\n";

        }

        // Remove trailing new line
        return label.Trim(); 

    }

    // Print order details
    public void PrintOrderDetails()

    {

        Console.WriteLine("Customers in Order:");
        foreach (var customer in _customers)

        {

            Console.WriteLine($"- {customer.Name}, Address: {customer.GetShippingAddress()}");

        }


        Console.WriteLine("Products Ordered:");
        foreach (var product in _products)

        {

            Console.WriteLine($"- {product.Name} (ID: {product.ProductId}): ${product.Price} x {product.Quantity} = ${product.TotalCost()}");

        }


        Console.WriteLine($"Total Amount: ${CalculateTotalCost()}");
        
    }
}
