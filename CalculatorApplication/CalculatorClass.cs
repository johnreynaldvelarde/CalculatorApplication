using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate F Formula<F>(F arg1);

    public class CalculatorClass
    {
        public Formula<double> info;

    }
}
