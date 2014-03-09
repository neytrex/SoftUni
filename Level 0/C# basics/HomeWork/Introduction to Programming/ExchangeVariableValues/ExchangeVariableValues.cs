//Problem 10.	Exchange Variable Values
//Declare two integer variables a and b and assign them with 
//5 and 10 and after that exchange their values. Print the 
//variable values before and after the exchange.

namespace ExchangeVariableValues
{
    using System;

    internal class ExchangeVariableValues
    {
        private static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("A: {0}", a);
            Console.WriteLine("B: {0}", b);

            Console.WriteLine();
            Console.WriteLine();

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A: {0}", a);
            Console.WriteLine("B: {0}", b);
        }
    }
}