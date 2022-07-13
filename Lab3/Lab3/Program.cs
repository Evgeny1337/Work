using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            MassivClass massiv = new MassivClass(20);
            massiv.Withdraw();
            Console.WriteLine();
            Console.WriteLine($"Ответ: {massiv.GetCount()}");
        }
    }
}
