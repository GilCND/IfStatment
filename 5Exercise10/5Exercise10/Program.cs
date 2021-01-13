/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 5Exercise10
Objective: 
Write a program that applies bonus points to given scores in the range
[1…9] by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error
message.
 */

using System;

namespace _5Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double score;

            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please inform the Score: ");
            score = Convert.ToUInt32(Console.ReadLine());



            //If the score is between 1 and 3, the program multiplies it by 10.
            if (score >=1 && score <=3)
            {
                score *= 10;
            }
            //If the score is between 4 and 6, the program multiplies it by 100.
            if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            //If the score is between 7 and 9, the program multiplies it by 1000.
            if (score >= 7 && score <= 9)
            {
                score *= 1000;
            }
            //If the score is 0 or more than 9, the program prints an error
            if (score == 0 || score > 9)
            {
                Console.WriteLine("Error!");
            }

            //Print total
            Console.WriteLine("The total is: {0}", score);


        }
    }
}
