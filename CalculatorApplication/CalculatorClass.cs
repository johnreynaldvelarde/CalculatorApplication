﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Information<T>(T arg1);

    public class CalculatorClass
    {
        public Information<string> info;

    }
}
