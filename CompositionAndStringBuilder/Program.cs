using CompositionAndStringBuilder.Entities;

namespace CompositionAndStringBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's awesome!");
            Comment c3 = new Comment("Have a nice night!");
            Comment c4 = new Comment("Bye!");


            Post p1 = new Post(
                DateTime.Parse("15/09/2023 14:20:22"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);
            
            Post p2 = new Post(
                DateTime.Parse("29/08/2023 23:14:19"),
                "Good night folks!",
                "See you later",
                5
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            
            
            


        }
    }
}

