using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Log : AbstractLog
    {
        private readonly string _name, _message;
        public Log(ISave save, string name, string message) : base(save)
        {
            _name = name;
            _message = message;
            _save = save;
        }

        public  override void Save()
        {
            _save.SaveTo(_name, _message);
        }
    }
}
