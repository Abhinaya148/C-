using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal static class MyExtensions
    {
        public static int Wordcount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int call(this string s)
        {
            return s.Length;

        }
        static void Main(string[] args)
        {
            string s = "hello wordl";
            int i = s.Wordcount();
            Console.WriteLine(i);
            int length = s.Length;
            Console.WriteLine(length);
        }
    }
}
    

