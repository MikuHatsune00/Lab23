using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }
        static void Factorial (int n)
        { int a = 1;
            for (int i = 1; i < n; i++)
            {
                a *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(a);
        }
        static async void FactorialAsync(int n)
        { await Task.Run(() => Factorial(n)); }

    }
}
