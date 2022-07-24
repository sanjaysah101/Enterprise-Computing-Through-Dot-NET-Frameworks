//3 : Find out whether the given number is odd or even.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
                Console.Write("{0} is even number",n);
            else
                Console.Write("{0} is odd number",n);

        }
    }
}