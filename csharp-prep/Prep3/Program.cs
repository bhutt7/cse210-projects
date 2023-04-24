using System;

class Program
{
    static void Main(string[] args)
    {
        int magic, guess;

        Random randomGen = new Random();
        magic = randomGen.Next(1, 70);
        
        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magic) {
                Console.WriteLine("Good job! You guessed it!");
            } else if (guess < magic) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("Lower");
            }

        } while (guess != magic);
    }
}