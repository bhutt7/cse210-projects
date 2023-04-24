using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int value;

        do {
            Console.Write("Enter a number: ");
            value = int.Parse(Console.ReadLine());

            if (value != 0) {
                numbers.Add(value);
            }

        } while (value != 0);

    }
}