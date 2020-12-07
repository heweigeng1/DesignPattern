using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Bus : IWhistle
    {

        public void Whistle()
        {
            Console.WriteLine("滴~~~~滴滴");
        }
    }
}
