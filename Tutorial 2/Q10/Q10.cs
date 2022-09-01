/*
10: Given a matrix mat[][] of size N x M, where every row and column is sorted in increasing order, and a number X is given. The task is to find whether element X is present in the matrix or not.

 

Example 1:

Input:

N = 3, M = 3

mat[][] = 3 30 38 

         44 52 54 

         57 60 69

X = 62

Output:

0

Explanation:

62 is not present in the

matrix, so output is 0

 

Example 2:

Input:

N = 1, M = 6

mat[][] = 18 21 27 38 55 67

X = 55

Output:

1

Explanation:

55 is present in the

matrix at 5th cell.

 

Your Task:

You don't need to read input or print anything. You just have to complete the function matSearch() which takes a 2D matrix mat[][], its dimensions N and M and integer X as inputs and returns 1 if the element X is present in the matrix and 0 otherwise.

 

Expected Time Complexity: O(N+M).

Expected Auxiliary Space: O(1).

 

Constraints:

1 <= N, M <= 1005

1 <= mat[][] <= 10000000

1<= X <= 10000000

*/


using System;

namespace Q10;

class program{
    public static void Main(String[] args){
        int n, m;
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());

        int[, ] arr = new int[n, m];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int x;
        int flag = 0;
        x = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(arr[i, j] == x){
                    flag = 1;
                }
            }
        }
        // if(flag > 0){
        //     Console.WriteLine(flag);
        // }
            Console.WriteLine(flag);
        

    }
}