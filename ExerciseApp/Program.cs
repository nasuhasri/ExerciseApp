using System;

namespace ExerciseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void StopWatch()
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Duration();
        }

        public static void Post()
        {
            var post = new Post();

            post.Title = "Topic 1";
            post.Description = "Topic 1 description";
            post.UpVote();
            post.UpVote();
            post.UpVote();

            var vote = post.CountVote;
            Console.WriteLine("Number of post vote: {0}", vote); // return 3

            post.DownVote();
            post.DownVote();

            var vote1 = post.CountVote;
            Console.WriteLine("Number of post vote: {0}", vote1); // return 1
        }
    }
}
