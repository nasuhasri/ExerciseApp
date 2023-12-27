using System.Collections.Generic;

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
}
