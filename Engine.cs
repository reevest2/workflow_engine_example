using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class Engine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTasks())
            {
                task.Execute();
            }
        }
    }
}
