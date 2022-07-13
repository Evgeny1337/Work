using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class SummClass
    {
        private double _number;
        private double _numberStep;
        public void Summ(string number)
        {
            var res = double.TryParse(number, out _numberStep);
            _number += _numberStep;
        }
        public double GetSumm()
        {
            return _number;
        }
    }
}
