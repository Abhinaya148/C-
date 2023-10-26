using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("enter your Branch");
            string branch = Console.ReadLine();
            //Console.WriteLine($"I am from {branch} branch");
            Console.WriteLine("enter your roll no");

            int roll_no = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"i am from {branch} branch. And My roll no is {roll_no}");
        }
    }
}
