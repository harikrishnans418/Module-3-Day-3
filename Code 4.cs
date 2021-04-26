using System.IO;
using System;

class Class6
{
    public int a;
    Class6(int a)
    {
       this.a = a;
    }
        public static void Main()
        {
            Class6 class6 = new Class6(6);
            Console.WriteLine(class6.a);
            Console.ReadLine();
        }
}