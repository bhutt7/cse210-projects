using System;

class Program
{
    static void Main(string[] args)
    {
        Listing list = new Listing("list","list",20);
        string value = list.GetPrompt(list.GetList());
        Console.WriteLine(value);
    }
}