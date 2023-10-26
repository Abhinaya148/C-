using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 56;
            student.Name = "Tara";
            student.Branch = "CSE";
            string str=student.display();
            
            Console.WriteLine(str);
            string sub = student.Attend("Maths");
            Console.WriteLine(sub);
            Console.ReadLine();
        }
    }
}
