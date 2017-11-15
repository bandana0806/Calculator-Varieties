using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public delegate double MathOperationEventHandler(double operand1, double operand2);

    public class ArithmeticOperation
    {
        private Storage _storage;
        private MathOperationEventHandler _handler;
        private Math _math;
        public ArithmeticOperation(Storage storage)
        {
            _math = new Math();
            _storage = storage;
        }

        public MathOperationEventHandler Operation(char choice)
        {
            switch (choice)
            {
                case '+':
                    _handler = _math.Add;
                    break;
                case '-':
                    _handler = _math.Subtract;
                    break;
                case '*':
                    _handler = _math.Multiply;
                    break;
                case '/':
                    _handler = _math.Divide;
                    break;

                default: break;
            }
            return _handler;
        }
    }
}

