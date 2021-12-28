using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class Engine
    {
        private readonly IWorkflow _workflow;
        public Engine(IWorkflow workflow)
        {
            _workflow = workflow;
        }

        public void Execute()
        {
            _workflow.Upload("Uploading video");
            _workflow.Email("Emailing video");
            _workflow.Call("Calling third party service");
            _workflow.Status("Upadting video status");
        }
    }
}
