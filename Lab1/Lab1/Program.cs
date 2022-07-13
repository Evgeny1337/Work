using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            Encoding encoding = Encoding.GetEncoding("Ascii");
            try
            {
                char[] massiv = new char[] { (char)Convert.ToInt32(Console.ReadLine()) };
                byte[] bytes = encoding.GetBytes(massiv);
                if ((Convert.ToChar(encoding.GetString(bytes)) > 'a' && Convert.ToChar(encoding.GetString(bytes)) < 'z')
                    || (Convert.ToChar(encoding.GetString(bytes)) > 'A' && Convert.ToChar(encoding.GetString(bytes)) < 'Z'))
                {
                    Console.WriteLine($"Английский символ: {encoding.GetString(bytes)}");
                }
                else
                {
                    Console.WriteLine($"Другой символ: {encoding.GetString(bytes)}");
                }
            }
            catch { Console.WriteLine("Вы ввели не число"); };
        }
    }
}
