using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PoliceCar : IWhistle
    {

        public void Whistle()
        {
            Console.WriteLine("比布比布");
        }
    }
}
