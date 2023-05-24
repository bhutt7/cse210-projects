using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 11, 35);
        Console.WriteLine(reference.Display());

        Word word = new Word("word;");
        Console.WriteLine(word.Display());
        word.Hide();
        Console.WriteLine(word.Display());

    }
}