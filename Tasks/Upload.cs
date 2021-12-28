using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    internal class Upload : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Upload video");
        }
    }
}
