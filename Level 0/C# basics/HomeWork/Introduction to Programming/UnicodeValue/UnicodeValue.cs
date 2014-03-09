//Problem 5.	Unicode Value
//Declare a character variable and assign it with 
//the symbol that has Unicode code 72, and then print 
//it. Hint: first, use the Windows Calculator to find 
//the hexadecimal representation of 72. The output should be “H”.

namespace UnicodeValue
{
    using System;

    internal class UnicodeValue
    {
        private static void Main()
        {
            int ch = 72;

            Console.WriteLine((char)ch);
        }
    }
}