using System;

namespace c_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var incorrectValue = true;
            while (incorrectValue)
            {
                try
                {
                    Console.Write("\nInput the First Number: ");
                    var number1 = int.Parse(Console.ReadLine());
                    Console.Write("\nInput the Second Number: ");
                    var number2 = int.Parse(Console.ReadLine());
                    var temp = number1;
                    number1 = number2;
                    number2 = temp;
                    Console.Write($"\nAfter Swapping, first number is {number1} and second number is  {number2}");
                    incorrectValue = false;
                }
                catch (System.FormatException)
                {
                    Console.Write("\nPlease input numerical values only");
                }
            }
        }
    }
}
