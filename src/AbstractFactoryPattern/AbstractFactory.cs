using System;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IWheel Wheel(string name);
        public abstract IWhistle Whistle(string name);
    }
}
