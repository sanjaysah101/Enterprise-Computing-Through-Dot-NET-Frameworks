namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] units = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            Console.Write("Input: ");
            string n = Console.ReadLine();
            
            for(int i = 0; i < n.Length; i++){
                Console.Write("{0} ", units[n[i]-'0']);
            }
        }              
    }
}