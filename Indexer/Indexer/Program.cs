using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Test
    {

        /*
            Syntax:

        [access modifier] [return type] this [argument list] 
         */

        private int[] marks = new int[3];
        //Method 1

       /* public int this [int index]
        {
            get { return marks[index]; }
            set { marks[index] = value;  }
        }*/
       //method 2
       public int this [int index]
        {
            get=>marks[index];
            set=>marks[index] = value;
        }

        public int add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test[0] = 10;           //It will work as vertual array
            test[1] = 20;
            Console.WriteLine(test[0]);
            Console.WriteLine(test.add(4, 6));
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            var square = list.Select(x => x * x);
            foreach (int i in square)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
