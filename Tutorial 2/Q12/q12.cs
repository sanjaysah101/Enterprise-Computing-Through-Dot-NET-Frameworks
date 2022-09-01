/* 
Write a Program to find the eligibility of admission for a  professional course
based on the following criteria:
Marks in Maths >=65
Marks in Phy >=55
Marks in Chem>=50 and
Total in all three subject >=180 or
Total in Math and Physics >=140
INPUT:
Input the marks obtained in Maths :72
Input the marks obtained in Physics :65
Input the marks obtained in Chemistry :51
OUTPUT:
The candidate is eligible for admission.
*/

using System;

namespace Q12;

class program{
    static void Main(String[] args){
        int math, phy, chem;    
        Console.Write("Input the marks obtained in Maths: ");
        math = Convert.ToInt32(Console.ReadLine());
        // Console.ReadLine();
        Console.Write("Input the marks obtained in Physics: ");
        phy = Convert.ToInt32(Console.ReadLine());
        // Console.ReadLine();
        Console.Write("Input the marks obtained in Chemistry: ");
        chem = Convert.ToInt32(Console.ReadLine());
        
        if(eligibleForAdmission(math, phy, chem)){
            Console.WriteLine("The candidate is eligible for adminssion");
        }else{
            Console.WriteLine("The candidate is not eligible for adminssion");
        }
    }
    static bool eligibleForAdmission(int math, int phy, int chem){
        if(math >= 65 && phy >= 55 && chem >= 50 && ((math + phy + chem) >= 180) || (math + phy) >= 140){
            return true;
        }
        return false;
    }
}