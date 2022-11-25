using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Student
    {
        public static int SID;
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sname = null;
            /* Student student = new Student();
             student.Id = 23;
             student.Name = "sdf";
             Console.WriteLine(student.Name);
             Console.WriteLine(student.Id);*/
            //Student.SID = student.Id;
            //Console.WriteLine(sname);

            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                Student student = null;
                Console.WriteLine(x / y);
                Console.WriteLine(student.Id);
            }
            
            catch (System.Exception e)
            {
                showerror();
            }


            Console.ReadKey();
        }
        public static void showerror()
        {
            
            Console.WriteLine("erro");
        }
    }
}
