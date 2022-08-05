/*
5 : Rearrange the given code to correct the program. The resultant program will be to enter 5 elements into an array and print sum of these elements.
using System;
namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            for (int i = 0; i < 5; i++){
                string str = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++){
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}",sum);
            int[] arr = new int[5];
            int sum = 0;
            arr[i] = Convert.ToInt32(str);
            Console.Write("Enter Element {0}: ", i);
            Console.Read();
        }    
    }
} 

Output:
Enter Element 0: 1
Enter Element 1: 2
Enter Element 2: 3
Enter Element 3: 4
Enter Element 4: 5
Sum of Elements : 15


*/
using System;
namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++){
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 5; i++){
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}",sum);
            Console.Read();
        }    
    }
} 