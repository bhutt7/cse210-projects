using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video one = new Video("Funny Jokes", "Silly James", 614);

        one.AddComment(new Comment("Arnold", "This is funny!"));
        one.AddComment(new Comment("Johnny", "LOL ROFL"));
        one.AddComment(new Comment("Bethany","I laughed so hard!"));

        videos.Add(one);

        Video two = new Video("God loves us - Music Video","Jessica Andrews",242);

        two.AddComment(new Comment("Jeffrey","So amazing! Such beautiful music."));
        two.AddComment(new Comment("Gertrude","Jesus is amazing!"));
        two.AddComment(new Comment("Annalise","Wonderful, you have a stunning singing voice!"));

        videos.Add(two);

        Video three = new Video("Acrobatics for Beginners", "Jody Flipsalot", 743);

        three.AddComment(new Comment("Stan","You make it look so easy."));
        three.AddComment(new Comment("Sandra","This is a great guide for starting acrobats! Can't wait for your next video."));
        three.AddComment(new Comment("Carol","Do you do videos on gymmnastics too?"));

        videos.Add(three);

        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
}