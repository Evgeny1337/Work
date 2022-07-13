using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class DigiClass
    {
        private int _number;
        public DigiClass(int number)
        {
            _number = number;
        }
        public int GetDigit()
        {
            var res = 0;
            do
            {
                res++;
                _number = _number / 10;
            }while(_number != 0);
            return res;
        }
    }
}
