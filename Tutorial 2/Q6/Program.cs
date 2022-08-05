/*
6: Write missing statement to get the desired output.
using System;
public class Hello3{
   public static void Main(string[] args){
      Console.WriteLine("Hello, World!");
      Console.WriteLine("You entered the following {0} command line arguments:",args.Length );
          //………………………………Missing statement-1……………………………….//      
          //………………………………Missing statement-2……………………………….//      
          //………………………………Missing statement-3……………………………….//      
          //………………………………Missing statement-4……………………………….//      
   }
}

Output:
-------------------
Hello, World!
You entered the following 4 command line arguments:
A
B
C
D
*/
using System;
public class Hello3{
    public static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Console.WriteLine("You entered the following {0} command line arguments:",args.Length );
        // for(int i = 0; i < args.Length; i++){
        //     Console.WriteLine(args[i]);
        // }
        foreach(object i in args){
            Console.WriteLine(i);
        }
   }
}