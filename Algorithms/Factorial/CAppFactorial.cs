using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class CAppFactorial
    {
        private static int Fact(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else return n * Fact(n - 1);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(string.Format("i = {0}, fact = {1}", i, Fact(i)));
            Console.ReadKey();
        }
    }
}
