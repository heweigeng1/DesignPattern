using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class FileLog : ISave
    {
        public void SaveTo(string name, string message)
        {
            Console.WriteLine($"file log-{name}-{message}");
        }
    }
}
