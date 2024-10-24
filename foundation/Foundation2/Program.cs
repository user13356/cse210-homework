using System;

class Program

{

    static void Main(string[] args)

    {

        // Create addresses
        Address address1 = new Address("544 Tree Rd", "Roger Town", "FL", "USA");
        Address address2 = new Address("221 Cat St", "Apple city", "AC", "EU");

        // Create customers
        Customer customer1 = new Customer("Peet Milek", address1);
        Customer customer2 = new Customer("Arges Botha", address2);

        // Create products
        Product product1 = new Product("TV", "P001", 445.11m, 1);

        // Quantity 2 at the end
        Product product2 = new Product("DVD", "P002", 12.56m, 2); 
        Product product3 = new Product("Keyboard", "P003", 22.44m, 1);

        // Create an order
        Order order = new Order();
        order.AddCustomer(customer1);
        order.AddCustomer(customer2);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        // Print order details
        order.PrintOrderDetails();

        // Print package label
        Console.WriteLine("\n" + order.GeneratePackageLabel());

    }
}
