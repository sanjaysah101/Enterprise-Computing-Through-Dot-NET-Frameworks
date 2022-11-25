     using System;

    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            square(ref x);
            Console.WriteLine("Sqaure of x: {0}", x);
            square(ref x);
            Console.WriteLine("Sqaure of x: {0}", x);
        }

         // Define Square method with out parameter
        public static void square(ref int a)
        {
            a *= a;
        }
    }
