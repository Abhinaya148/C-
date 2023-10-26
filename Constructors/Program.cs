using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        /* public class ParentClass

        {
            public ParentClass()
            {
                Console.WriteLine("Parent class constructor called");
            }
            
        }
        public class ChildClass: ParentClass
        {
            public ChildClass() {
                Console.WriteLine("Child class constructor called");
            }
            
        }
        public static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
        }
        */
        public class ParentClass

        {
            public ParentClass()
            {
                Console.WriteLine("Parent class constructor called");
            }
            public ParentClass(string msg)
            {
                Console.WriteLine(msg);
            }

        }
        public class ChildClass : ParentClass
        {
            public ChildClass() : base("HEllo Abhinaya")
            {
                Console.WriteLine("Child class constructor called");
            }

        }
        public static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
        }
    }
}
