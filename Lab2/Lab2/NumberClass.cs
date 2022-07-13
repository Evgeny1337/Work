using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class NumberClass
    {
        private string _number;
        private bool _isNumber;
        public NumberClass(string number)
        {
            _isNumber = int.TryParse(number, out int result);
            _number = number;
        }
        public string GetResult()
        {
            if (_isNumber)
            {
                return $"{MaxNumber()} - максимальный элемент";
            }
            else
            {
                return "Введено не число";
            }
        }
        private int MaxNumber()
        {
            var max = Convert.ToInt32(_number[0].ToString());
            for (int i = 0; i < _number.Length; i++)
            {
                if (Convert.ToInt32(_number[i].ToString()) > max)
                {
                    max = Convert.ToInt32(_number[i].ToString());
                }
            }
            return max;
        }
    }
}
