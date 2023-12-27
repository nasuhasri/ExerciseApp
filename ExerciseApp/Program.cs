using System;
using System.Collections.Generic;
using System.Threading;

namespace ExerciseApp
{
    public interface IExecute
    {
        void Execute();
    }

    public class VideoWorkflow : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Run video workflow...");
        }
    }

    public class WebServiceWorkflow : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Run webservice workflow...");
        }
    }

    public class EmailWorkflow : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Run send email workflow...");
        }
    }

    public class ChangeStatusWorkflow : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Run change status workflow...");
        }
    }

    public class WorkflowEngine
    {
        public void Run(List<IExecute> workflow)
        {
            foreach (var workflowItem in workflow)
            {
                workflowItem.Execute();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var listWorkflow = new List<IExecute>();
            listWorkflow.Add(new VideoWorkflow());
            listWorkflow.Add(new WebServiceWorkflow());
            listWorkflow.Add(new EmailWorkflow());
            listWorkflow.Add(new ChangeStatusWorkflow());

            var workFlowEngine = new WorkflowEngine();
            workFlowEngine.Run(listWorkflow);
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

        public static void Stack()
        {
            var stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            stack.Clear(); // after clear, exception message appeared

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
