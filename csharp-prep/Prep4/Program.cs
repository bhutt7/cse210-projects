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

        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int highest = 0;
        foreach (int num in numbers) {
            if (num > highest) {
                highest = num;
            }
        }
        Console.WriteLine($"The largest number is: {highest}");
    }
}