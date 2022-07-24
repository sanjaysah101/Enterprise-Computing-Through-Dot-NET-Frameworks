namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(fib(i) <= n){
                Console.Write("{0} ", fib(i));
                i++;                
            }
        }

        static int fib(int n){
            if(n <=1){
                return n;
            }
            return fib(n-1)+fib(n-2);
        }
        
    }
}