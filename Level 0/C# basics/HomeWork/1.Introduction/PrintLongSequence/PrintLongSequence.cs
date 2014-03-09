//Print Long Sequence
//Write a program that prints the first 1000 members of the 
//sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how 
//to use loops in C# (search in Internet).

namespace PrintLongSequence
{
    using System;
    using System.Collections.Generic;

    class PrintLongSequence
    {
        static void Main()
        {
            int length = 1000;
            List<int> numbers = new List<int>();
            for (int i = 2; i <= length + 2; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i * -1);
                }
                else
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
