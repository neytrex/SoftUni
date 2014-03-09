//Problem 3.	Comparing Floats
//Write a program that safely compares floating-point numbers 
//with precision eps = 0.000001. Note that we cannot directly 
//compare two floating-point numbers a and b by a==b because of t
//he nature of the floating-point arithmetic. Therefore, we 
//assume two numbers are equal if they are more closely to each 
//other than a fixed constant eps. Examples:
namespace ComparingFloats
{
    using System;
    using System.Text;

    internal class ComparingFloats
    {
        private static void Main()
        {
            double first = 5.00000001d;
            double second = 5.00000003d;
            CompareNumbers(first, second);

            first = -0.00000077d;
            second = 0.00000007d;
            CompareNumbers(first, second);

            first = -4.999999d;
            second = -4.999998d;
            CompareNumbers(first, second);

            first = 5.3d;
            second = 6.01d;
            CompareNumbers(first, second);
        }

        public static void CompareNumbers(double inputFirst, double inputSecond)
        {
            double firstNumber;
            double secondNumber;

             firstNumber = Precision(inputFirst);
            secondNumber = Precision(inputSecond);
            Console.Write(string.Format("{0} == {1}", inputFirst.ToString("F7"), inputSecond.ToString("F7")));
            Console.WriteLine("  Result : {0}", firstNumber == secondNumber);
        }

        public static double Precision(double number, int precision = 6)
        {
            StringBuilder outputNumber = new StringBuilder();

            string inputNumber = number.ToString("F7");


            int counter = 0;
            bool startCounting = false;
            foreach (char item in inputNumber)
            {
                if (startCounting)
                {
                    counter++;
                    if (counter == precision + 1)
                    {
                        break;
                    }

                }
                else if (item == '.' || item == ',')
                {
                    startCounting = true;
                }

                outputNumber.Append(item);
            }

            return double.Parse(outputNumber.ToString());
        }
    }
}