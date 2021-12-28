using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class Workflow : IWorkflow
    {
        public void Call(string message)
        {
            Console.WriteLine(message);
        }

        public void Email(string message)
        {
            Console.WriteLine(message);
        }

        public void Status(string message)
        {
            Console.WriteLine(message);
        }

        public void Upload(string message)
        {
            Console.WriteLine(message);
        }
    }
}
