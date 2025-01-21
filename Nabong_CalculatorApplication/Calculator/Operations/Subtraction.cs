using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabong_CalculatorApplication.Calculator.Operations
{
    public class Subtraction : Calculator // Inheritance from the base class, Engr.
    {
        // For the Addition Operation and Displaying Output :>
        public override double Calculate()
        {
            double difference = Num_One - Num_Two;
            return difference;
        }
        public override string DisplayOperation()
        {
            return $"{Num_One} - {Num_Two} = {Calculate()}";
        }
    }
}
