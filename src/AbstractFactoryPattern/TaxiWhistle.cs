using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class TaxiWhistle : IWhistle
    {
        public void Whistle()
        {
            Console.WriteLine("我是的士:滴~~~~~~~~~~");
        }
    }
}
