using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialiser
{

    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Person person = new Person { FirstName = "Surabhi", LastName = "Abhinaya",Age = 21};
          
            Console.WriteLine($"Name:{person.FirstName} {person.LastName}, Age:{person.Age}");
        }
    }

}