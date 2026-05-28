using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45.00, 1));

        // ORDER 2 (International)
        Address address2 = new Address(
            "45 Queen Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P200", 699.99, 1));
        order2.AddProduct(new Product("Charger", "P201", 19.99, 3));

        // DISPLAY ORDER 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("\n-----------------------------\n");

        // DISPLAY ORDER 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}