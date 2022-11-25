using System;
public class Hello3
{
   public static void Main(string[] args)
   {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("You entered the following {0} command line arguments:", args.Length );

        foreach(string arg in args)
        {
            Console.WriteLine(arg);
        }
   }
}

