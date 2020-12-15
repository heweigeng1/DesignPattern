using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ManagerResponse : AbstractResponse
    {
        public override void Handle(string message)
        {
            Console.WriteLine("经理签字=>");
            Console.WriteLine(message);
        }
    }
}
