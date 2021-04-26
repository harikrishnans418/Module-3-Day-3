using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    class Class2
    {
        void sum()
        {
            Console.WriteLine("Iam empty");
        }
        void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void sum(float a, float b, float c)
        {
            Console.WriteLine(a + b + c);
        }
        void sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main()
        {
            Class2 program1 = new Class2();
            Console.WriteLine("Enter a and b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            program1.sum(float.Parse(a.ToString()), float.Parse(b.ToString()), float.Parse(c.ToString()));
            program1.sum(a.ToString(), b.ToString());
        }
    }
}
 