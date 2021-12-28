using System;

namespace workflow_engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new Call());
            workflow.Add(new Email());
            workflow.Add(new Status());
            workflow.Add(new Upload());

            var engine = new Engine();
            engine.Run(workflow);

            Console.ReadLine();
        }
    }
}
