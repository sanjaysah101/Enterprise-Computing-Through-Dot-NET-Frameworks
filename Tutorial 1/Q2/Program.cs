using System;

namespace Tutorial1{
    class Q1{

        static void border(){
            for(int i = 0; i < 20; i++)
                Console.Write("$ ");
        }
         static void Main(String[] args){
            border();
            string name, dob, address, city, pincode, state, country, email;
            name = "Sanjay Kumar Sah";
            dob = "28/06/2000";
            address = "105 - A, Boys Hostel\n\t RK University";
            city = "Rajkot";
            pincode = "360020";
            state ="Gujrat";
            country = "India";
            email = "ssah007@rku.ac.in";
            Console.WriteLine("\n\nName: {0}",name);
            Console.WriteLine("DOB: {0}\nAddress: {1}\nCity: {2}\nPincode: {3}\nState: {4}\nCountry: {5}\nEmail: {6}\n\n", dob, address, city, pincode,state,country,email);

            border();
            Console.ReadLine();
        }
    }
}
