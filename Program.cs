using System;
using System.Text;

namespace c_sharp_practice
{
    public static class Program
    {
        public static string Repeat(this string s, int n)
            => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();

       public static string remove_char(string str, int n)
        {
            // second integer removes given number of characters, starting from the first
            return str.Remove(n, 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0)); 
        }
    }
}
