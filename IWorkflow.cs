using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public interface IWorkflow
    {
        void Upload(string message);
        void Call(string message);
        void Email(string message);
        void Status(string message);
    }
}
