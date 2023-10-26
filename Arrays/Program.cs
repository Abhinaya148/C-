using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16[] n = { 12, 13, 14 };
            Console.WriteLine(n.Length);

            string[] course = { "CSE", "IT", "ECE", "EEE","AI" };
            //Console.WriteLine(course[2]);
            for (int i = 0; i < course.Length; i++) ;
            {
                Console.WriteLine(course[i]);
            }
            
         }
    }
}
