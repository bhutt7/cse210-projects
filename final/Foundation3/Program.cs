using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        Lecture lecture = new Lecture("A Lecture on Lectures", "Learn from the best on how to give a lecture!", "August 23", "5:00pm", new Address("101 E Education St", "Moscow", "Idaho"), "Dr. Lex Cher", 400);
        events.Add(lecture);

        Reception reception = new Reception("United at Last!", "Join Anthony and Carol Wedden in celebration after their wedding!", "September 9", "3:00pm", new Address("4242 W Edding Cir", "Rexburg", "Idaho"), "newlywedden@gmail.com");
        events.Add(reception);

        Gathering gathering = new Gathering("Trunk or Treat", "Bring your car, your kids, and lots of candy to take part in the Star 1st Ward Annual Trunk or Treat. Don't forget a costume!", "October 31", "7:00pm", new Address("484 S Main St", "Star", "Idaho"), "Clear skies, slightly chilly");
        events.Add(gathering);

        int number = 1;
        foreach (Event e in events)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"**Event {number}**");
            Console.WriteLine("---------------------------");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("---------------------------");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("---------------------------");
            Console.WriteLine(e.ShortDetails());
            Console.WriteLine("-------------------------------------------");
            number += 1;
        }
    }
}