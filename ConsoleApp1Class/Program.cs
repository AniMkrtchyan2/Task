using System;
using System.Diagnostics;


namespace ConsoleApp1Class
{
    public delegate int MathDelegate(int n);
    public class MathMetod
    {
        public int countDivisors(int n)
        {
            int cnt = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    // If divisors are equal,
                    // count only one
                    if (n / i == i)
                        cnt++;
                    // Otherwise count both
                    else
                        cnt = cnt + 2;
                }
            }
            return cnt;
        }
        public int squared(int n)
        {
            return (n * n);
        }
        public int lastMethode(int n)
        {

            Console.WriteLine($"third methode called");
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathMetod divcount = new MathMetod();
            MathDelegate mathDelegate = new MathDelegate(divcount.countDivisors);
            Console.WriteLine(mathDelegate(36));
            mathDelegate += divcount.squared;
            Console.WriteLine(mathDelegate(36));
            mathDelegate += divcount.lastMethode;
            mathDelegate.Invoke(10);
            Console.ReadKey();
        }
    }
}

