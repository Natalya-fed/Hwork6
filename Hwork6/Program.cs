using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string p = Console.ReadLine();
            string[] s = p.Split(' ');
            int max = 0;
            string maxWord = "";
            foreach (string a in s)
            {
                int word = a.Length;
                if (max < word)
                {
                    max = word;
                    maxWord = a;
                }
                else
                {
                    if (max == word)
                    {
                        max = word;
                        maxWord += ", " + a;
                    }
                }
            }
            Console.WriteLine($"Самые длинные слова:\n{maxWord}");
            Console.ReadKey();
        }
    }
}
