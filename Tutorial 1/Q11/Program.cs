// 11  Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
// Based on the gender prefix the name Mr. & Ms.
// NAME : Hillary Clinton
// GENDER : F

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char gender =  Char.ToUpper(Console.ReadLine()[0]);
            if(gender == 'M')
                Console.WriteLine("Mr. {0}", name);
            else if(gender == 'F')
                Console.WriteLine("Ms. {0}", name);
        }    
    }
}