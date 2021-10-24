using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string pa = Console.ReadLine();
            string[] s = pa.Split(' ');
            string pa1 = "";
            string ap = "";
            foreach (string a in s)
            {
                pa1 += a.ToLower();
            }
            for (int i = pa1.Length - 1; i >= 0; i--)//перебираем с конца
            {
                ap += pa1[i].ToString();
            }
            if (pa1 == ap)
            {
                Console.WriteLine($"Строка палиндрома:\n{pa1}\n{ap}");
            }
            else
            {
                Console.WriteLine($"Строка не палиндрома:\n{pa1}\n{ap}");
            }
            Console.ReadKey();
        }
    }
}
