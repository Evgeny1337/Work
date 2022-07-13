using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            SummClass summ = new SummClass();
            Console.WriteLine("Введите числа: ");
            while (true)
            {
                var number = Console.ReadLine();
                if(String.IsNullOrEmpty(number))
                {
                    break;
                }
                else
                {
                    summ.Summ(number);
                }
            }
            Console.WriteLine($"Сумма чисел: {summ.GetSumm()}");
        }
    }
}
