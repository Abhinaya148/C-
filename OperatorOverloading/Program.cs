using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator num1= new Calculator(1500);
            Calculator num2 = new Calculator(2700);
            Calculator num3 = new Calculator();
            num3=num1 + num2;
            num1.display();
            num2.display();
            num3.display();
        }
    }
}
