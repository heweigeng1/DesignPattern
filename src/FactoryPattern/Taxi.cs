﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Taxi : IWhistle
    {

        public void Whistle()
        {
            Console.WriteLine("比比比比");
        }
    }
}
