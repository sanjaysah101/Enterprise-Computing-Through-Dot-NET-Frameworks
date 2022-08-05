// 9 : Given an array A containing 2*N+2 positive numbers, out of which 2*N numbers exist in pairs whereas the other two number occur exactly once and are distinct. Find the other two numbers.

using System;
namespace Q9;

public class TwoNonRepeatingXOR{
    public void find(int[] arrA){
        int xor = arrA[0];
        for(int i = 1; i < arrA.Length; i++){
            // This will find XOR of all element in an array i.e 1 ^ 2 ^ 3 ^ 2 ^ 1 ^ 4 = 7
            /* 
                0 ^ 0 = 0
                0 ^ 1 = 1
                1 ^ 0 = 1
                1 ^ 1 = 0
                xor is used to check if two element is equal or not
            */
            xor ^= arrA[i];
            // Console.WriteLine(xor);
        }

        int right_most_set_bit = xor & ~(xor-1); // This will give 1 in the right most set bit 

        int x = 0,  y = 0;

        // Console.WriteLine(right_most_set_bit);
        for(int i = 0; i < arrA.Length; i++){
            int a = arrA[i];
            if((a & right_most_set_bit) != 0){
                x = x ^ arrA[i];
            }else{
                y = y ^ arrA[i] ;
            }
        }

        if(y > x){
            Console.WriteLine("{0} and {1} occur exactly once.", x, y);
        }
        else{
            Console.WriteLine("{0} and {1} occur exactly once.", y, x);
        }

    }
}
class program{
    static void Main(string[] args){
        TwoNonRepeatingXOR t1 = new TwoNonRepeatingXOR();
        TwoNonRepeatingXOR t2 = new TwoNonRepeatingXOR();
        int[] arr1 = {1, 2, 3, 2, 1, 4};
        int[] arr2 = {2, 1, 3, 2};
        t1.find(arr1);        
        t2.find(arr2);        
    }
}
