using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class BusWheel : IWheel
    {
        public void Wheel()
        {
            Console.WriteLine("我是巴士的轮子,24*2*4");
        }
    }
}
