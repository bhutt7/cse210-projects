using System;

// Exceeding Requirements: In the reflection activity, I added functionality to only repeat questions after all had been displayed once. I did this by adding the questions to a secondary list and removing them from the primary list, then repopulating the primary list once it is empty with the secondary list.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing exercise");
            Console.WriteLine("  2. Start reflection exercise");
            Console.WriteLine("  3. Start listing exercise");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Breathing breathe = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathe.Start();
                    breathe.RunBreathe();
                    breathe.Finish();
                    break;
                case "2":
                    Reflection reflect = new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflect.Start();
                    reflect.RunReflect();
                    reflect.Finish();
                    break;
                case "3":
                    Listing list = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    list.Start();
                    list.RunList();
                    list.Finish();
                    break;
                default:
                    Console.Clear();
                    break;
            }
            
        } while (choice != "4");
    }
}