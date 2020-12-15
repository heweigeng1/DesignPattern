using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class WorkerResponse : AbstractResponse
    {
        public WorkerResponse()
        {
            Next = new MonitorResponse();
        }

        public override void Handle(string message)
        {
            Console.WriteLine("工人发起请假");
            Next.Handle(message);
        }
    }
}
