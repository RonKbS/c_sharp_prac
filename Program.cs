using System;
using System.Text;

namespace c_sharp_practice
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var incorrectValue = true;
            while (incorrectValue)
            {
                try
                {
                    Console.Write("\nInput Number to get Multiplication Table: ");
                    var number = int.Parse(Console.ReadLine());
                    var limit = 0;
                    while (limit < 13)
                    {
                        Console.WriteLine($"{limit*number}");
                        limit++;
                    }
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
