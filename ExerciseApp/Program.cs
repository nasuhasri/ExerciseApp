using System;
using System.Collections.Generic;
using System.Threading;

namespace ExerciseApp
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        // if we put list instead of IEnumerable, the client will have access to our private list
        // because we already have the Add() and we dont want the client to add method directly on our private lists
        // IEnumerable is purely interface that do not have any method on it and allow us to enumerate a list
        // so we return the readonly of our list
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
    public class VideoWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run video workflow...");
        }
    }

    public class WebServiceWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run webservice workflow...");
        }
    }

    public class EmailWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run send email workflow...");
        }
    }

    public class ChangeStatusWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run change status workflow...");
        }
    }

    public class WorkflowEngine
    {
        public void RunOld(List<ITask> workflow)
        {
            foreach (var workflowItem in workflow)
            {
                workflowItem.Execute();
            }
        }

        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception)
                {
                    // logging
                    // terminate and persists the state of workflow
                    throw;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Add(new VideoWorkflow());
            workflow.Add(new WebServiceWorkflow());
            workflow.Add(new EmailWorkflow());
            workflow.Add(new ChangeStatusWorkflow());

            var workFlowEngine = new WorkflowEngine();
            workFlowEngine.Run(workflow);
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
