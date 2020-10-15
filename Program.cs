using System;
using System.Linq.Expressions;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello professor, this is an auto populated array for Project #3B!");

            // Create the array and declarate the array's size and associate them to each other
            const int SIZE = 25;
            int[] numbersarray = new int[SIZE];
            
            // Iterate through the array using a For loop. Automatically populate array using a function and display values
            for (int i = 0; i < SIZE; i++)
            {
                numbersarray[i] += (i+1);
                Console.WriteLine("Element value = " + numbersarray[i]);
            }
            Console.ReadKey(true);
        }
    }
}
