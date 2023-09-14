using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
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
        public double GetDifference(double diff1 , double diff2)
        {
            return diff1 - diff2;
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
