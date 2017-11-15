using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Calculator
{
    public class Keypad
    {
        private List<char> _keyList;

        public Keypad()
        {
            _keyList = new List<char>();
            Key();
        }

        public char Read()
        {
            char key = Console.ReadKey(true).KeyChar;
            if (_keyList.Contains(key))
            { return key; }
            return char.MinValue;
        }

        public List<char> KeyList { get => _keyList; }

        private void Key()
        {
            //ascii code added in key list for 0-9, +,-,*,/
            for (int ascii = 42; ascii < 58; ascii++)
            {
                if (ascii != 44)
                    _keyList.Add((char)ascii);
            }

            //= Key for result
            _keyList.Add('=');
            //Enter key for reult
            _keyList.Add((char)13);
            //escape Key for Clear
            _keyList.Add((char)27);
        }
    }
}
