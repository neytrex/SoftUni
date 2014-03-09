//Problem 1.	Declare Variables
//Declare five variables choosing for each of them the most appropriate 
//of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
//the following values: 52130, -115, 4825932, 97, -10000. Choose a large 
//enough type for each number to ensure it will fit in it. Try to compile 
//the code. Submit the source code of your Visual Studio project as part of
//your homework submission.

namespace DeclareVariables
{
    using System;

    internal class DeclareVariables
    {
        private static void Main()
        {
            ushort @ushort = 52130;
            Console.WriteLine(@ushort);

            byte @byte = 115;
            Console.WriteLine(@byte);

            uint @uint = 4825932;
            Console.WriteLine(4825932);

            @byte = 97;
            Console.WriteLine(@byte);

            short @short = -10000;
            Console.WriteLine(@short);
        }
    }
}