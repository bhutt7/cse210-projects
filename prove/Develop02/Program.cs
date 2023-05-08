using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        string x = prompt.GetRandomPrompt();
        Console.Write(x);
    }
}