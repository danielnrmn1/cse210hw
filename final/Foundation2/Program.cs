using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two products
        Product product1 = new Product("Product 1", 1, 10, 2);
        Product product2 = new Product("Product 2", 2, 20, 3);

        // Create two addresses
        Address address1 = new Address("123 Main Street", "City 1", "State 1", "USA");
        Address address2 = new Address("456 Elm Street", "City 2", "State 2", "Canada");

        // Create two customers with their respective addresses
        Customer customer1 = new Customer("Customer 1", address1);
        Customer customer2 = new Customer("Customer 2", address2);

        // Create two orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to the orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        // Display packing labels, shipping labels, and total costs for the orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());

        Console.ReadLine();
    }
} 