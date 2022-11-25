using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Collections;

namespace Practice
{
    public delegate int Calculate(int num1, int num2);
    private int[] marks ;

    public int this[int index]
	{
		get { return marks[index]; }
		set { marks[index] = value; }
	}

    delegate 
    internal class Program
    {
        static int add(int num1, int num2)
        {
            return num1 + num2;
        } 
        static int sub(int num1, int num2)
        {
            return num1 - num2;
        } 
        static int mul(int num1, int num2)
        {
            return num1 * num2;
        } 
        static int div(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Calculate[] calulate = new Calculate[4];
            calulate[0] = add;
            calulate[1] = sub;
            calulate[2] = mul;
            calulate[3] = div;
            /*
            Console.WriteLine("Enter your choise: ");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calulate[choise](num1, num2));
            */

            ArrayList mylist = new ArrayList();
            mylist.Add("sanjay");
            mylist.Add(3);
            Console.WriteLine(mylist.Capacity);
            Console.ReadKey();

        }
    }
}*/
