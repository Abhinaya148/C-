using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        
        //method hiding
        public string Attend(string sub)
        {
            return sub;
        }
        public string display()
        {
            return  Name + " " + Id + " " + Branch;
            
        }
    }
}

