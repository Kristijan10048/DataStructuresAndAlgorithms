using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinomialDistro
{
    class CAppBinomial
    {
        /// <summary>
        /// Binomial distribution. I need to check what it is.
        /// </summary>
        /// <param name="N"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static double Binomial(int N, int k, double p, int i = 1)
        {
            Console.WriteLine("{0}. N = {1}, k = {2}",i, N, k);
           
            if ((N == 0) || (k < 0))
                return 1.0;
            return (1.0 - p) * Binomial(N - 1, k, p, ++i) + p * Binomial(N - 1, k - 1, p, ++i);
        }

        /// <summary>
        /// estimate the number of recursive calls that would be used by the code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //2*((n+1) + k+2)
            //n! *2 - (n-k)! +1
            //(2*n - n-k)! + 1
            int n = 3, k = 3;
            double val = Binomial(n, k, 0.1);
            Console.Write("Val = {0}", val);
            Console.ReadKey();
        }
    }
}
