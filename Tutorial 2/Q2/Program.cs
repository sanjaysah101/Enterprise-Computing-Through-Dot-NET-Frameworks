/* 2 : Write missing statement to get the desired output.

Output:
a is not less than 20
value of a is : 100
*/

using System;
namespace DecisionMaking
{ 
    class Program{
        static void Main(string[] args){
            /* local variable definition */
            int a = 100;
            /* check the boolean condition */
            if (a < 20){
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }else{
                /* if condition is false then print the following */
                   //………………………………Missing statement-1……………………………….//
                Console.WriteLine("a is not less than 20");

             }
               //………………………………Missing statement-2……………………………….//                
                Console.WriteLine("value of a is ", a);
              Console.ReadLine();
        }
    }
}