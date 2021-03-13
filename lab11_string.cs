using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть слово:");
            string str = Console.ReadLine();
            char x, y;
            Console.WriteLine("Введіть 2 символа");
            x = Convert.ToChar(Console.ReadLine());
            y = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == x) Console.WriteLine(str.Insert(i+1, $"{y}"));
            }
            Console.ReadKey();
        }
    }
}
