using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1: Domestic Customer (USA)
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 25.50m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK-202", 80.00m, 1));
        order1.AddProduct(new Product("Desk Pad", "DP-303", 15.00m, 1));

        // ORDER 2: International Customer (Brazil)
        Address address2 = new Address("Av. Paulista, 1000", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Pedro Ribeiro", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "UH-404", 45.00m, 1));
        order2.AddProduct(new Product("Monitor Stand", "MS-505", 60.00m, 1));

        // DISPLAY RESULTS
        DisplayOrderDetails(order1, 1);
        Console.WriteLine("\n");
        DisplayOrderDetails(order2, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNumber)
    {
        Console.WriteLine($"ORDER #{orderNumber}");
        Console.Write(order.GetPackingLabel());
        Console.WriteLine();
        Console.Write(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
    }
}