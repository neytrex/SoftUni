//Problem 9.	Print a Sequence
//Write a program that prints the first 10 members of the sequence: 
//2, -3, 4, -5, 6, -7, ...

namespace PrintASequence
{
    using System;
    using System.Collections.Generic;

    class PrintASequence
    {
        static void Main()
        {
            int length = 12;
            List<int> numbers = new List<int>();
            for (int i = 2; i <= length; i++)
            {
                if (i%2 != 0)
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
