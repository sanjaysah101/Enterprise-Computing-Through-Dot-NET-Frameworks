//C# program to convert a binary number into a decimal number.

using System;

class BinToDecimal
{
    static void Main(string[] args)
    {
        int binNum      = 0;
        int decNum      = 0;
        int i           = 0;
        int rem         = 0; 
        
        Console.Write("Enter a binary number: ");
        binNum = int.Parse(Console.ReadLine());

        /*
      Missing code

        */

        while (binNum > 0) 
        {
            rem = binNum % 10;
            decNum += rem * (int)Math.Pow(2, i);
            i++;
            binNum /= 10;
        }
        Console.WriteLine("\nDecimal number: " + decNum);
    }
}