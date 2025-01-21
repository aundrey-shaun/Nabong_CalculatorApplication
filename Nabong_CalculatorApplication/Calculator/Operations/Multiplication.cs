using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabong_CalculatorApplication.Calculator.Operations
{
    public class Multiplication : Calculator // Inheritance from the base class, Engr.
    {
        // For the Addition Operation and Displaying Output :>
        public override double Calculate()
        {
            double product = Num_One * Num_Two;
            return product;
        }
        public override string DisplayOperation()
        {
            return $"{Num_One} * {Num_Two} = {Calculate()}";
        }
    }
}
