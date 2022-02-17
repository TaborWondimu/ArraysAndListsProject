using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
              int[] vs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
             var odd = new List <int>(); 
             var even = new List <int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else if (i % 2 > 0)
                {
                    odd.Add(i);

                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("These are the odd numbers");
            foreach (int i in odd)
            {   
                Console.WriteLine(i);
            }
            Console.WriteLine("These are the even numbers");
            foreach (int i in even)
            {
               Console.WriteLine(i);
            }
              
             
        }
    }
}
