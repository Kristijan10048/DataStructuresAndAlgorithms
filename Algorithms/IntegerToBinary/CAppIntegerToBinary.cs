using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CAppIntegerToBinary
    {
        private static string ToBin(int n)
        {
            string buffer = string.Empty;
            //if input value is less then 1 exit. 
            if (n < 1)
                return string.Empty;

            //calculate binary values for positive number n
            for (int i = n; i > 0; i /= 2)
            {
                int r = i % 2;
                Console.WriteLine(string.Format("i = {0}, r = {1}",i, r));
                buffer = r + buffer;
            }

            return buffer;
        }

        static void Main(string[] args)
        {
            int numb = 10;
            string result = ToBin(numb);

            Console.WriteLine("Number {0} in binary {1}", numb, result);
            Console.ReadKey();
        }
    }
}
