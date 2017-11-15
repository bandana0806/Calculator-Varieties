using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ProcessingUnit
    {
        private char[] _operator = new char[] { '+', '-', '*', '/', '=' };
        private char[] _operand = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char _dot = '.';
        private string _number = "0";
        private int _dotCount;
        private int _flag;
        private char[] _resultOperator = new char[] { (char)13, '=' };
        private Storage _storage;
        private double tempValue;
        private Display _display;

        public ProcessingUnit(Storage storage)
        {
            _storage = storage;
            _display = new Display();
        }
        public void Process(char key)
        {
            if (_operand.Contains(key))
            {
                if (!_number.Equals("0"))
                {
                    _number += key.ToString();
                }
                _number = key.ToString();
                _display.Write(key + "");
            }
            else if (_operator.Contains(key))
            {
                _storage.Operator = key;
                if (_flag == 0)
                    _storage.Operand1 = ProcessNumber(_number);
                _number = "0";
                _dotCount = 0;
                _flag++;
                _display.Write(key + "");
            }
            else if (key == _dot && _dotCount == 0)
            {
                _dotCount++;
                _number += _dot;
                _display.Write(key + "");
            }
            else if (_resultOperator.Contains(key))
            {
                _storage.Operand2 = ProcessNumber(_number);
                _number = "0";
                _dotCount = 0;
                Evaluation();
                Console.Clear();
                _display.Write("" + _storage.Operand1);
            }
        }
        private double ProcessNumber(string number)
        {
            number.TrimStart('0');
            //If number ends with .
            if (number.EndsWith("."))
            {
                number = number.Trim('.');
            }
            return Convert.ToDouble(number);
        }

        private double Evaluation()
        {
            ArithmeticOperation arithmetic = new ArithmeticOperation(_storage);
            _storage.Operand1 = arithmetic.Operation(_storage.Operator).Invoke(_storage.Operand1, _storage.Operand2);
            _storage.Operand2 = 0;
            return _storage.Operand1;
        }
    }
}
