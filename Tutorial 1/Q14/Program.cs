// 15.  Write a Program to check whether the given no is Armstrong no or not.

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            double newNumber = 0;
            double pow = Math.Floor(Math.Log10(temp) + 1);
            while(temp>0){
                double rem = temp % 10;
                rem = Math.Pow(rem, pow);
                newNumber += rem;
                temp /= 10;
            }
                Console.WriteLine("{0} is Armstrong number", newNumber);
            if(n == newNumber)
                Console.WriteLine("{0} is Armstrong number", n);
            else
                Console.WriteLine("{0} is not Armstrong number", n);
        }              
    }
}