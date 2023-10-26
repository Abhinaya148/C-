using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int CalculatorDelegate(int a, int b);
    internal class Program
    {
        static int Add(int x, int y)
        { 
            return x + y; 
        }
        static int Sub(int x, int y) 
        {
            return x - y; 
        }
        static void Main(string[] args)
        {
            CalculatorDelegate addDelegate= Add;
            CalculatorDelegate subDelegate= Sub;
            int result1 = addDelegate(20, 7);
            int result2 = subDelegate(44, 8);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

