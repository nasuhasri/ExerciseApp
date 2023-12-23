using System;

namespace ExerciseApp
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        // accessible from outside but the set can only be done in constructor
        public int CountVote { get; private set; } 

        public Post()
        {
            CountVote = 0;
        }

        public void UpVote()
        {
            Console.WriteLine(CountVote++);
        }

        public void DownVote()
        {
            Console.WriteLine(CountVote--);
        }
    }
}
