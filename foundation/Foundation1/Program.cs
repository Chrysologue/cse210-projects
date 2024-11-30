using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C# Programming", "John Doe", 900, new List<Comment>
        {
           new Comment("Alice Green", "Great intro! Learned a lot about the basics of C#."),
           new Comment("Tom White", "I wish the examples were a bit more complex."),
           new Comment("Sophie Black", "Really helpful for beginners. Thanks for explaining everything step by")
        });
        Video video2 = new Video("Mastering LINQ in C#", "Jane Smith", 1200, new List<Comment>
        {
            new Comment("Chris Brown", "Amazing! LINQ is now so much clearer for me."),
            new Comment("Maria Red", "The part about 'join' was a bit confusing, could you explain it again?"),
            new Comment("Daniel Purple", "This should be mandatory for anyone learning C#!"),
            new Comment("Lucy Yellow", "Thanks for the real-life examples, they really helped me understand")
        });
        Video video3 = new Video("C# Collections: Lists, Dictionaries, and Arrays", "Michael Brown", 1500, new List<Comment>
        {
            new Comment("Ben White", "I never understood the difference between Lists and Arrays, this video clarified it!"),
            new Comment("Grace Pink", "The section on Dictionaries was excellent. I had no idea they could be used like this."),
            new Comment("Javier Black",  "Can you explain performance differences between using Lists vs Arrays?")
        });
        Video video4 = new Video("Understanding Asynchronous Programming in C#", "Sarah Johnson", 1100, new List<Comment>
        {
            new Comment("Oliver Green", "Asynchronous programming always confused me, but now I feel more confident about it."),
            new Comment("Natalie Red", "Your explanation of async/await was really helpful, thank you!"),
            new Comment("James White", "Can you give an example of async in a real-world project?"),
            new Comment("Emily Blue", "This was exactly what I needed to understand asynchronous tasks in C#.")
        });

        List<Video> videos = new List<Video>{video1, video2, video3, video4};
        foreach(var video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title} - Author: {video._author} - Length: {video._length} seconds - Number of comments: {video.NumberOfComment()}");
            Console.WriteLine("Comments:");
            video.ShowAllComment();
        }
    }
}