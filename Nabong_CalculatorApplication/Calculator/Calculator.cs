using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabong_CalculatorApplication.Calculator
{
    // ABSTRACT BASE CLASS HEHE
    public abstract class Calculator
    {
        /* Note: I used a double po instead of an integer para kung
         * may user (let's assume) na maglalagay ng double, we'll still
         * be able to compute it. hehe.
         */

        // Private Fields for N1 and N2 :>
        private double _num_one;
        private double _num_two;

        // Pubblic Properties, woah. haha
        public double Num_One { get; set; }
        public double Num_Two { get; set; }

        // Abstract for Calculation
        public abstract double Calculate();

        // Virtual Method to Display
        public virtual string DisplayOperation()
        {
            return "Base Calculator";
        }
    }
}
