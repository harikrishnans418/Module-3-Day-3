using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Class13
    {
        public readonly double pi = 3.14;
        public Class13(double pi)
        {
            this.pi = pi;
        }
        public static void Main()
        {
            const double PI = 3.14;
            readonly double pi = 3.14;
            Class13 class13 = new Class13(PI);
            Console.WriteLine(class13.pi);
            Console.ReadLine();
        }
    }
}