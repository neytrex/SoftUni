//Problem 2.	Float or Double?
//Which of the following values can be assigned to a 
//variable of type float and which to a variable of 
//type double: 34.567839023, 12.345, 8923.1234857, 
//3456.091? Write a program to assign the numbers in 
//variables and print them to ensure no precision is lost.

namespace FloatOrDouble
{
    using System;

    internal class FloatOrDouble
    {
        private static void Main()
        {
            double @double = 34.567839023d;
            Console.WriteLine(@double);

            float @float = 12.345f;
            Console.WriteLine(@float);

            @double = 8923.1234857d;
            Console.WriteLine(@double);

            @float = 3456.091f;
            Console.WriteLine(@float);
        }
    }
}