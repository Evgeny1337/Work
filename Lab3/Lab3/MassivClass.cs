using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MassivClass
    {
        private static int _mLength;
        private int[] _massiv;
        Random random = new Random();
        public MassivClass(int mLength)
        {
            _mLength = mLength;
            _massiv = new int[_mLength];
            FillMassiv();
        }
        public void Withdraw()
        {
            Console.Write("Massiv: ");
            Console.WriteLine();
            for (int i = 0;i<_mLength;i++)
            {
                Console.Write($"{_massiv[i]} ");
            }
        }
        private void FillMassiv()
        {
           for(int i=0;i<_mLength;i++)
           {
                _massiv[i] = random.Next(-15, 14);
           }
        }
        public int GetCount()
        {
            var max = _massiv[0];
            for(int i=0;i<_mLength;i++)
            {
                if(_massiv[i]>max)
                {
                    max = _massiv[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            return _massiv.Where(x => Math.Abs(x) > max).Count();
        }
    }
}
