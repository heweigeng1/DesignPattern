using Core;
using System;

namespace FactoryPattern
{
    public class CarWheelFactory
    {
        public IWhistle CreateWhistle(string name)
        {
            switch (name)
            {
                case "Bus":
                    return new Bus();
                case "Taxi":
                    return new Taxi();
                case "PoliceCar":
                    return new PoliceCar();
                default:
                    throw new Exception("object is null");
            }
        }
    }
}
