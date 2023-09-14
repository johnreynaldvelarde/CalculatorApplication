using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    // public delegate F Formula<F>(F arg1);

    public delegate double Formula (double arg1 , double arg2);

    public class CalculatorClass
    {
        public Formula calculateDelegate;

        public event Formula CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                calculateDelegate += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                calculateDelegate -= value;
            }
        }

        public double GetSum(double sum1, double sum2)
        {
            return sum1 + sum2;
        }
        public double GetDifference(double diffrence)
        {
            return diffrence;
        }
        public double GetProduct(double multi)
        {
            return multi;
        }
        public double GetQuotient(double quo)
        {
            return quo;
        }


    }
}
