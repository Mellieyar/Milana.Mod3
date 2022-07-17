using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milana.Mod3.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            long res1 = Ffactorial(n);
            long res2 = Rfactorial(n);

            Console.WriteLine($"Для n={n}");
            Console.WriteLine($"Результат функции Ffactorial = {res1}");
            Console.WriteLine($"Результат функции Rfactorial = {res2}");

            Console.ReadLine();
        }

        static long Ffactorial(int n)
        {
            long res = 1;

            for(int i=1; i<=n; i++)
            {
                res *= i;
            }

            return res;
        }

        static long Rfactorial(int n)
        {
            return n < 1 ? 1 : n * Rfactorial(n - 1);
        }
    }
}
