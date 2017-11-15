using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ControlUnit
    {
        private Keypad _keypad;
        private ProcessingUnit _processUnit;
        private Storage _storage;
        private Display _display;

        public ControlUnit()
        {
            //_display = new Display();
            _keypad = new Keypad();
            _storage = new Storage();
            _processUnit = new ProcessingUnit(_storage);
            Processor();
        }

        public void Processor()
        {
            //  Console.Write('0');
            while (true)
            {
                char key = _keypad.Read();
                _processUnit.Process(key);
            }

        }
    }
}
