using System.IO;
using System;

interface Vehicle
{
    void ChangeGear (int a);
    void speedUp (int a);
    void applyBrakes (int a);
}
class Bicycle : Vehicle
{
    int speed;
    int gear;
    public void ChangeGear(int newGear)
    {
        gear = newGear;
    }
    public void speedUp(int increment)
    {
        speed = speed + increment;
    }
    public void speedUp(int decrement)
    {
        speed = speed - decrement;
    }
    public void printStates()
    {
        Console.WriteLine("speed:"+ speed + "gear");
    }
}
class Bike : Vehicle
{
    int speed;
    int gear;
    public void ChangeGear(int newGear)
    {
        gear = newGear;
    }
    public void speedUp(int increment)
    {
        speed = speed + increment;
    }
    public void speedUp(int decrement)
    {
        speed = speed - decrement;
    }
    public void printStates()
    {
        Console.WriteLine("speed:"+ speed + "gear");
    }
}
class Client
{
    public static void Main()
    {
        Bicycle bicycle = new Bicycle();
        bicycle.ChangeGear(2);
        bicycle.speedUp(3);
        bicycle.applyBrakes(1);
        Console.WriteLine("bicyle present state:");
        bicycle.presentState();
        
        Console.WriteLine("--------------");
        
        Bike bike = new Bike();
        bike.ChangeGear(2);
        bike.speedUp(3);
        bike.applyBrakes(1);
        Console.WriteLine("bike present state:");
        bike.presentState();
        Console.ReadLine();
    }
}