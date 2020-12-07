using System;

namespace AbstractFactoryPattern
{
    public class SuperFactory
    {
        public AbstractFactory Create(string name)
        {
            switch (name)
            {
                case "Wheel":
                    return new WheelFactory();
                case "Whistle":
                    return new WhistleFactory();
                default:
                    throw new Exception("fail");
            }
        }
    }
}
