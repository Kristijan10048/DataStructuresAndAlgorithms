using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EuclidGCD
{
    class CAppGcd
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>GCD</returns>
        private static int Gcd(int p, int q)
        {
            if (p == 0)
                return q;
            else if (q == 0)
                return p;
            else
            {
                int r = p % q;
                Console.WriteLine("p = {0}, q = {1}, r = {2}", p, q, r);
                return Gcd(q, r);
            }
        }

        static void Main(string[] args)
        {
            int p = 270, q = 192;
            int tmpGcd = Gcd(p, q);
            Console.WriteLine("Gcd of p = {0} and q = {1} is {2}", p, q, tmpGcd);

            p = 1111111;
            q = 1234567;
            tmpGcd = Gcd(p, q);
            Console.WriteLine("Gcd of p = {0} and q = {1} is {2}", p, q, tmpGcd);

            Console.ReadKey();
        }
    }
}
