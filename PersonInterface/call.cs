using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class RoleModel : Person, IDriver, IStudent, IEmployee
    {
        public void Drive()
        {
            Console.WriteLine($"{Name} is driving.");
        }

        public void Years()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working at {Address} location.");
        }
    }
}
