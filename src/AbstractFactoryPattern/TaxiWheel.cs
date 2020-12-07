using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class TaxiWheel : IWheel
    {
        public void Wheel()
        {
            Console.WriteLine("我是的士的轮子:21*1*4");
        }
    }
}
