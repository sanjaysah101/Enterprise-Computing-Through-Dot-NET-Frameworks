using System;
namespace CalculatorApplication
{
   class NumberManipulator
   {
      /*
	Write swap function for the given code
      */
        public void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
   }
  class TestRef
   {
      static void Main(string[] args)
      {
         NumberManipulator n = new NumberManipulator();
         /* local variable definition */
         int a = 100;
         int b = 200;

         Console.WriteLine("Before swap, value of a : {0}", a);
         Console.WriteLine("Before swap, value of b : {0}", b);

         /* calling a function to swap the values */
         n.swap(ref a, ref b);

         Console.WriteLine("After swap, value of a : {0}", a);
         Console.WriteLine("After swap, value of b : {0}", b);

         Console.ReadLine();
      }
   }
}

