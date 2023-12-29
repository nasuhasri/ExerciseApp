using System;
using System.Collections.Generic;

namespace ExerciseApp
{
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
}
