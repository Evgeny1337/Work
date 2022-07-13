using System;

namespace Lab4
{
    class Program
    {
          
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var number = Convert.ToInt32(Console.ReadLine());
            DigiClass digi = new DigiClass(number);
            Console.WriteLine($"Ответ: {digi.GetDigit()}");
        }
    }

}
