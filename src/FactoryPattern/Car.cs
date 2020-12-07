using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Car : IWhistle
    {

        public void Whistle()
        {
            Console.WriteLine("滴 滴");
        }
    }
}
