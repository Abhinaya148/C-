using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyClass<T1, T2>
    {
        public T1 MyCall { get; set; }
        public void Method(T1 p1, T2 p2)
        {
            Console.WriteLine($"p1={p1}");
            Console.WriteLine($"p2={p2}");

        }
    }
        class Person
        {
           static void Main(string[] args)
            {
                MyClass<int, string> obj = new MyClass<int, string>();
                obj.MyCall = 234;
                obj.Method(45, "hello");
                Console.WriteLine($"{obj.MyCall}");
                
            }
       
        }
    }


