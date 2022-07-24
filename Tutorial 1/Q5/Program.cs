// 5 : Write output of the program. Also write comment for each line for the following code.

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,fact=1;
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            n = Convert.ToInt32(str);
            for (int i = 1; i <= n; i++){
                fact = fact * i;
            }
            Console.WriteLine("Factorial : {0}",fact);
           Console.Read();
        }
    }
}