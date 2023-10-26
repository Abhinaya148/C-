using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new RoleModel
            {
                Name = "Ram",
                Age = 21,
                Address = "L.b Nagar"
            };
            IDriver driver = person;
            IStudent student = person;
            IEmployee employee = person;

            driver.Drive();
            student.Years();
            employee.Work();
        }

    }
}
