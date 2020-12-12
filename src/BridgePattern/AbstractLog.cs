using System;

namespace BridgePattern
{
    public abstract class AbstractLog
    {
        protected ISave _save;
        protected AbstractLog(ISave save)
        {
            _save = save;
        }

        public abstract void Save();
    }
}
