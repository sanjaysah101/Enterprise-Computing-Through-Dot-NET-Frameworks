namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();

            Console.WriteLine("{0}", toggle(str));
        }

        static string toggle(string str){
            string s = "";

            foreach(Char c in str){
                if(Char.IsLower(c))
                    // Console.WriteLine(c);
                    s += Char.ToUpper(c);
                else if(Char.IsUpper(c))
                    s += Char.ToLower(c);
                else
                    s += c;
            }
            return s;
        }
    }
}