using System.IO;
using System;

abstract class Wholeseller
{
    public virtual string Discount()
    {
        return "10% Disount";
    }
}
class Retailer : Wholeseller
{
    public override string Discount()
    {
        return "Hello ! i am giving 5% discount";
    }
    public static void Main ()
    {
        Retailer class11 = new Retailer();
        Console.WriteLine(class11.Discount());
        Console.ReadLine();
    }
}