/* 4 : Input two number A and B. perform different operations using different operators and different data types available in C#. (Note : Follow all the operators and data types to do above task. Use Online help whenever necessary.)
*/

using System;

namespace Q4;

class Program{
    static void Main(String[] args){
        int a, b;
        Console.Write("A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToInt32(Console.ReadLine());
        calculate(a, b);
    }
    static void calculate(int a, int b){
        Console.WriteLine("Add: {0} + {1} = {2}", a, b, a+b);
        Console.WriteLine("Add: {0} - {1} = {2}", a, b, a-b);
        Console.WriteLine("Add: {0} * {1} = {2}", a, b, a*b);
        Console.WriteLine("Add: {0} / {1} = {2}", a, b, (b!=0)?(float)a/b:"Divided by Zero");
    }
}