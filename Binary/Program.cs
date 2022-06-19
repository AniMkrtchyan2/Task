using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2, c = 4, d=5, n = 19, m = 21;

            var result = (a > b) & (c == d) | (n < m) ? true : false;
            Console.WriteLine(result);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bitwise XOR");
            int result2;
            result2 = d ^ a;
            Console.WriteLine("{0} ^ {1} = {2}",d, a, result2);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bitwise OR");
            int result3;
            result3 = a | c;
            Console.WriteLine("{0} | {1} = {2}", a, c, result3);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bitwise AND");
            int firstNumber =6, secondNumber = 8, result4;
            result4 = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result4);
        }
    }
}
      

