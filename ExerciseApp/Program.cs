using System;
using System.Threading;

namespace ExerciseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch();
        }

        public static void StopWatch()
        {
            var stopWatch = new StopWatch();

            for (int i = 0; i < 3; i++)
            {
                stopWatch.Start();

                Thread.Sleep(1000); // 1000 miliseconds = 1 sec

                stopWatch.Stop();

                Console.WriteLine("Duration: ");
                stopWatch.Duration();

                Console.WriteLine("Please press enter to run stopwatch one more time: ");
                Console.ReadLine();
            }
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
