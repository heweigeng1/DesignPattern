﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public interface ISave
    {
        void SaveTo(string name, string message);
    }
}
