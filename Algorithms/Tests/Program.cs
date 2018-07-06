using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            IComparable a = 10, b = 4;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));

            a = 3; b = 11;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));

            a = 3; b = 3;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));

            Console.ReadKey();
        }
    }
}
