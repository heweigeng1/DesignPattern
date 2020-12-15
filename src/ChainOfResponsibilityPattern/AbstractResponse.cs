using System;

namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractResponse
    {
        protected AbstractResponse Next;
        public abstract void Handle(string message);
    }
}
