using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentInput = Console.ReadLine();
        int percent = int.Parse(percentInput);
        string letter;

        if (percent >= 90) {
            letter = "A";
        } else if (percent >= 80) {
            letter = "B";
        } else if (percent >= 70) {
            letter = "C";
        } else if (percent >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }
        Console.WriteLine($"You got a(n) {letter}!");

        if (percent >= 70) {
            Console.WriteLine("This means you pass! Congrats!");
        } else {
            Console.WriteLine("This means you fail! Better luck next time!");
        }
    }
}