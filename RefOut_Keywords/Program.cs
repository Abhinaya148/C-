using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //refkeyword();
            add();
        }

        private static void add()
        {
            int a = 3; int b = 5;
            Console.WriteLine(a + b);
        }

        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        private static void refkeyword()
        {
            int i = 1;
            Console.WriteLine("previous value of integer i: "+i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("current value of integer i: " + i.ToString());
        }
        /*public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 0
            Console.WriteLine("previous value of integer i: " + i.ToString());
            string test = GetNextNameByOut(out i);
            Console.WriteLine("current value of int i: " + i.ToString());
        }*/
    }
    
}
