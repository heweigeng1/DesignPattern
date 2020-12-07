using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class BusWhistle : IWhistle
    {
        public void Whistle()
        {
            Console.WriteLine("巴士鸣笛,比~~~~~~~~~~~~");
        }
    }
}
