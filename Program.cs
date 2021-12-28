using System;

namespace workflow_engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(new Workflow());
            engine.Execute();
        }
    }
}
