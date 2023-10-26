using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
            private static void MultipleInterface()
            {
                var Person = new Person()
                {
                    Name = "Swaraj Praneeth",
                    Age = 21,
                    Address = "New Delhi"
                };

                Console.WriteLine($" Name: {Person.Name}\n Age: {Person.Age}\n Address: {Person.Address}\n");
                Console.WriteLine("\n\n**IDriving interface methods**");
                IDriver.Drive();
                Person.StartDriveAge();
                Person.StopDrive();
                PersonRole.DriverAddress();

                Console.WriteLine("\n\n**IStudent interface methods**");
                Istudent.StudiesTime();
                PersonRole.StudentAge();
                PersonRole.DoHomeWork();

                Console.WriteLine("\n\n**IEmployee interface methods**");
                PersonRole.Work();
                PersonRole.AttendMeeting();
                PersonRole.RequestHoliday();
            }
    }
}
