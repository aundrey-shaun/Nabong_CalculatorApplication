using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabong_CalculatorApplication.Calculator.Operations
{
    public class Power : Calculator
    {
        // For the Addition Operation and Displaying Output :>
        public override double Calculate()
        {
            double difference = Math.Pow(Num_One, Num_Two);
            return difference;
        }
        public override string DisplayOperation()
        {
            return $"{Num_One} ^ {Num_Two} = {Calculate()}";
        }
    }
}
