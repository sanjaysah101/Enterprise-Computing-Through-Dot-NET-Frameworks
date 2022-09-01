/* 
13. Write a Program that will accept the amount and find how many minimum
no of notes you required for that.
(Using the rupee notes of 1, 2, 5, 10, 20, 50, 100, 200, 500, 2000)
Input: 5748
Output:
Notes of Rs.2000 = 2 Notes of Rs.500 = 3 Notes of Rs.200 = 1
Notes of Rs.20 = 2 Notes of Rs.10 = 0 Notes of Rs.5 = 1
Notes of Rs.2 = 1 Notes of Rs.1 = 1

*/

using System;

namespace Q11;

class program{
    static void Main(String[] args){
        int note, note2000, note500, note200, note100, note50, note20, note10, note5, note2, note1;
        note2000 = note500 = note200 = note100 = note50 = note20 = note10 = note5 = note2 = note1 = 0;
        note = Convert.ToInt32(Console.ReadLine());
        int cnt = 0;
        Console.WriteLine(note%2000);
        // if(note%2000 == 0){
            note2000 = note/2000;
            note %= 2000;
        // }
        // if(note%500 == 0){
            note500 = note/500;
            note %= 500;
        // }
        // if(note%200 == 0){
            note200 = note/200;
            note %= 200;
        // }
        // if(note%100 == 0){
            note100 = note/100;
            note %= 100;
        // }
        // if(note%50 == 0){
            note50 = note/50;
            note %= 50;
        // }
        // if(note%20 == 0){
            note20 = note/20;
            note %= 20;
        // }
        // if(note%10 == 0){
            note10 = note/10;
            note %= 10;
        // }
        // if(note%5 == 0){
            note50 = note/5;
            note %= 5;
        // }
        // if(note%2 == 0){
            note2 = note/2;
            note %= 2;
        // }
        // if(note%1 == 0){
            note1 = note/1;     
            note %= 1;
        // }

        // Console.WriteLine(note500);
        Console.WriteLine("Notes of Rs.2000 = "+ note2000 + " Notes of Rs 500 = " + note500 + " Notes of Rs.200 = "+note200+" Note of Rs.100 = "+note100+" Note of Rs.50 = "+note50+" Note of Rs.20 = "+note20 + " Note of Rs 10 = "+note10+" Note of Rs 5 = "+ note5 + " Note of Rs 2 = "+note2 + " Note of Rs 1 = "+note1);
    }
}