using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class WhistleFactory : AbstractFactory
    {
        public override IWheel Wheel(string name)
        {
            return null;
        }

        public override IWhistle Whistle(string name)
        {
            switch (name)
            {
                case "TaxiWheel":
                    return new TaxiWhistle();
                case "BusWheel":
                    return new BusWhistle();
                default:
                    throw new Exception("fail");
            }
        }
    }
}
