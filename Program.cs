using System;
using System.Text;

namespace c_sharp_practice
{
    public static class Program
    {
        public static string Repeat(this string s, int n)
            => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();

        static void Main(string[] args)
        {
            var incorrectValue = true;
            while (incorrectValue)
            {
                try
                {
                    Console.Write("\nInput Number to get Multiplication Table: ");
                    var number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{number} ".Repeat(4));
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
