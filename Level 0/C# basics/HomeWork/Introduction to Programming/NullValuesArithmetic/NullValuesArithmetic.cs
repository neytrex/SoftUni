//Problem 13.	Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. Try to print 
//these variables at the console. Try to add some number or the null literal to these variables 
//and print the result.


namespace NullValuesArithmetic
{
    using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number = null;

            Console.WriteLine(number == null ? "Null" : number.ToString());
            Console.WriteLine();
            Console.WriteLine((number + 10) == null ? "Null" : number.ToString());
        }
    }
}
