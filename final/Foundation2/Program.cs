using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Joshua", new Address("723 E Proper Place", "Portland", "Oregon", "USA")));

        order1.AddProduct(new Product("Silver Watch", 342561, 55, 1));
        order1.AddProduct(new Product("Tap Shoes", 783367, 40, 2));
        order1.AddProduct(new Product("Tablecloth", 923762, 14, 10));

        Order order2 = new Order(new Customer("Vivian", new Address("3383 S Affluence Way", "Ottawa", "Ontario", "Canada")));

        order2.AddProduct(new Product("Diamond Earrings", 892738, 264, 1));
        order2.AddProduct(new Product("Assorted Bath Bombs", 278348, 37, 25));
        order2.AddProduct(new Product("Wine Glass", 111938, 12, 8));

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("**Order 1**");
        Console.WriteLine("------------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine("------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine("------------------------");
        Console.WriteLine($"Total Price: ${order1.TotalCost()}");
        Console.WriteLine("--------------------------------------------");
        
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("**Order 2**");
        Console.WriteLine("------------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine("------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine("------------------------");
        Console.WriteLine($"Total Price: ${order2.TotalCost()}");
        Console.WriteLine("--------------------------------------------");
    }
}