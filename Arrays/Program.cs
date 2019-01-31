// Author: Joshua Cordle
// Date: 1/31/2019
// Comments: Populate an array with numbers and display them

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Populate array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (int i in numbers)
            {
                //Display each element of the array
                Console.WriteLine( "Element value = " + i );
            }
            //Close the program 
            Console.WriteLine("press any key to close the program...");
            Console.ReadKey(true);
        }
    }
}
