using System;
namespace day_3
{
interface inter1
void display();
}
class testClass:inter1 //class is inherited and interfaceis implemented
{
public void display()
{
Console.WriteLine("Hello");
}
public status void Main()
{
testClass t = new testClass();
t.display();
Console.ReadLine();

}
}
}