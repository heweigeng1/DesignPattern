using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class DbLog : ISave
    {
        public void SaveTo(string name, string message)
        {
            Console.WriteLine($"Dblog-{name}-{message}");
        }
    }
}
