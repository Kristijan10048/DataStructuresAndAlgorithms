using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class CAppFibonacci
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        private static int F(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
              int res = F(n - 1) + F(n - 2);
                Console.WriteLine("N = "+ n + "Res = " + res);
                return res;
            }
        }

        static void Main(string[] args)
        {
            for(int i = 0; i<=10; i++)
            {
                Console.Write(F(i) + " ");
            }

            Console.ReadKey();
        }
    }
}
