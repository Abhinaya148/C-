using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public string Email;
            public void PrintFullName() 
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }
        public class FullTimeEmployee: Employee 
        {
            public float YearlySalary;
        }
        public class PartTimeEmployee: Employee
        {
            public float HourlyRate;
        }
    public class program
    {
        public static void Main()
        {
            FullTimeEmployee FTE= new FullTimeEmployee();
            FTE.FirstName = "Surabhi";
            FTE.LastName = "Abhinaya";
            FTE.YearlySalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE= new PartTimeEmployee();
            PTE.FirstName = "Surabhi";
            PTE.LastName = "Sravya";
            PTE.HourlyRate = 4000;
            PTE.PrintFullName();
        }
    }
    }

