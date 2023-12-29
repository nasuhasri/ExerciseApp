using System.Collections.Generic;

namespace ExerciseApp
{
    // add or remove workflow
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
