namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine("{0}", change(num));
        }
        static string change(string n){
            char [] ch = n.ToCharArray();
            for(int i = ch.Length - 5; i < ch.Length; i++){
                ch[i] = 'X';
            }
            return new String(ch);
        }      
    }
}