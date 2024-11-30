using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new List<Product>
        {
            new Product("Laptop", "P123", 999.99, 1),
            new Product("Phone", "P124", 699.99, 2),
            new Product("Camera", "P125", 463.25, 3)
        },new Customer("Skipp Mark", new Address("123 Main St", "Anytown", "CA", "USA")));

        Order order2 = new Order(new List<Product>
        {
            new Product("Laptop", "P140", 999.99, 1),
            new Product("Phone", "P142", 699.99, 2),
            new Product("Camera", "P143", 463.25, 3)
        }, new Customer("Rachel Nina", new Address("456 Maple St", "Toronto", "Ontario", "Canada")));

        Order order3 = new Order(new List<Product>
        {
            new Product("Smart TV", "P205", 630.25, 1),
            new Product("Laptop", "P206", 1500.32, 1),
        }, new Customer("Chryso Rabearson", new Address("Lot Vs 20 Va", "TANA I", "Antananarivo", "Madagascar")));

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");
        Console.WriteLine("*************************************************");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");
        Console.WriteLine("*************************************************");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order3.GetTotalPrice()}");
    }
}