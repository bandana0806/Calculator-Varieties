using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math
    {
        public double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        public double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        public double Multiply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        public double Divide(double operand1, double operand2)
        {
            return operand1 / operand2;
        }
    }
}
\