using System;

namespace Lab2
{
    class Program
    { 
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            NumberClass number = new NumberClass(str);
            Console.WriteLine($"{number.GetResult()}");
        }
    }
   

}
