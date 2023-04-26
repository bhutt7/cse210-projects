// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");

mistborn.Display();

Book hp1 = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling");

hp1.Display();

Console.WriteLine(mistborn.isAvailable());