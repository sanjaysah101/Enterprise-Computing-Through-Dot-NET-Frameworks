using System;
class MyClient
{
      public static void Main()
      {
		try
		{
            int x = 0;
            int div = 100/x;
            Console.WriteLine(div);

		}
		catch (DivideByZeroException)
		{
			
            Console.WriteLine("Try to Divide By Zero");
		}
		finally
		{
			global::System.Console.WriteLine("The Finall Block Will always Execute");
		}
       }
} 
