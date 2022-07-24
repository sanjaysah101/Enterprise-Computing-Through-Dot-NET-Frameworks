// 6 : Write missing statement to get the desired output.
using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,result;
            Console.Write("Enter Number   1: ");
   //Missing statement
            string str = Console.ReadLine();

            a = Convert.ToInt32(str);
            Console.Write("Enter Number  2 : ");
   //Missing statement
            str = Console.ReadLine();

            b = Convert.ToInt32(str);
            Console.Write("Enter Number   3 : ");
            str = Console.ReadLine();
   //Missing statement
            c = Convert.ToInt32(str);
            
            result = Sum(a, b, c);
            Console.WriteLine("Sum {0}", result);
   //Missing statement        
            Console.Read();
        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x+y+z;
            return res;
        }
    }
}
