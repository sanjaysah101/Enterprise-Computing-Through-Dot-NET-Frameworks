using System;

namespace ConsoleApplication1
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            int x;
            x = Convert.ToInt32(str);
            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
        }
    }
}
