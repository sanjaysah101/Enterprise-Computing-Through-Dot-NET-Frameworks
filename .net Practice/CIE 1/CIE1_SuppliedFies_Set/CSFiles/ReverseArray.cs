using System;


    class ReverseArray
    {
        static void Main()
        {
            int[] arr1   = new int[5];
            int[] arr2 = new int[5];
            //Read numbers into array
            int i = 0;
            int j = 0;       

            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //Assign elements of arr1 from last to first element to arr2        
            for (i = 0,j=arr1.Length-1; i < arr1.Length; i++)
            {
                arr2[i] = arr1[j--];           
            }
            //Reverse array elements in arr2
            Console.WriteLine("Reverse elements : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: "+ arr2[i]);
            }
                
            
           
           

        }
    }
