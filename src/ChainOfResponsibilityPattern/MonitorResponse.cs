using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class MonitorResponse : AbstractResponse
    {
        public MonitorResponse()
        {
            Next = new ManagerResponse();
        }

        public override void Handle(string message)
        {
            Console.WriteLine("班长签名=>");
            Next.Handle(message);
        }
    }
}
