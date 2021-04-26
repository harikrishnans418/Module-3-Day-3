using System;
public class Class13
{
	public static void Main()
	{
        char[] arr1;
        int l,i;
        l=0;
        char ch;
        string str = "My name is Hari Krishnan S";
       l=str.Length;
       arr1 = str.ToCharArray(0, l); 

        Console.Write("\nAfter conversion, the string is : ");
        for(i=0; i < l; i++)
         {
          ch=arr1[i];
           if (Char.IsLower(ch)) 
              Console.Write(Char.ToUpper(ch)); 
              else
              Console.Write(Char.ToLower(ch)); 
        }
     Console.ReadLine();  
   }
}
