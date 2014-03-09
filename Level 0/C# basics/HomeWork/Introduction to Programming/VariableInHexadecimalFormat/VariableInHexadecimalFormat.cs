//Problem 4.	Variable in Hexadecimal Format
//Declare an integer variable and assign it with the 
//value 254 in hexadecimal format (0x##). Use Windows 
//Calculator to find its hexadecimal representation. 
//Print the variable and ensure that the result is “254”.

namespace VariableInHexadecimalFormat
{
    using System;

    internal class VariableInHexadecimalFormat
    {
        private static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:X}", number);
        }
    }
}