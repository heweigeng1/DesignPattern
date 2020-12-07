using System;

namespace AbstractFactoryPattern
{
    public class WheelFactory : AbstractFactory
    {
        public override IWheel Wheel(string name)
        {
            switch (name)
            {
                case "TaxiWheel":
                    return new TaxiWheel();
                case "BusWheel":
                    return new BusWheel();
                default:
                    throw new Exception("fail");
            }
        }

        public override IWhistle Whistle(string name)
        {
            return null;
        }
    }
}
