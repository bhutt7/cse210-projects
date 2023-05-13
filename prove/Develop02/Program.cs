using System;

// Exceeding Expectations: When the user creates a new entry, the program generates a prompt then removes it from the prompt list. Once the prompt list is empty, if the user tries to create a new entry, it instead tells them they have answered all prompts for the day (session), and sends them back to the menu.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu(journal);
        menu.Display();
    }
}