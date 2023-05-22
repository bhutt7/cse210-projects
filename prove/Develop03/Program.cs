using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 11, 35);
        Console.WriteLine(reference.Display());
    }
}