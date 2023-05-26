using System;

// Exceeding Expectations: Some of the words in a scripture will have punctuation, like commas and periods, which usually disappear when a word is hidden. Instead of hiding punctuation, I made it so the Word constructor checks each word punctuation at the end, so that the string of underscores representing a hidden word still has the punctuation. This makes it easier for the user to memorize the scripture, as the punctuation helps break up the scripture into smaller portions/phrases that can be easier to memorize.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 9, 28, 29);
        Scripture scripture = new Scripture(reference, "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.");
        string quit = "";
        bool done = false;

        scripture.Display();
        Console.Write("Press 'Enter' to continue, or type 'q' to quit.");
        quit = Console.ReadLine();
        
        while (quit != "q" & !done)
        {
            scripture.HideRandom();
            scripture.Display();
            done = scripture.IsComplete();
            Console.Write("Press 'Enter' to continue, or type 'q' to quit.");
            quit = Console.ReadLine();
        }
    }
}