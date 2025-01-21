using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabong_CalculatorApplication.Calculator.Operations
{
    public class Remainder : Calculator
    {
        // For the Addition Operation and Displaying Output :>
        public override double Calculate()
        {
            if (Num_Two == 0)
            {
                Console.WriteLine("Error! Cannot Get Remainder by Zero");
                return 0;
            }
            else
            {
                return Num_One % Num_Two;
            }
        }

        public override string DisplayOperation()
        {
            return $"{Num_One} % {Num_Two} = {Calculate()}";
        }
    }
}
