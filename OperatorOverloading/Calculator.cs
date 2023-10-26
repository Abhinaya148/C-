using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Calculator
    {
        public int number = 0;
        public Calculator() 
        {

        }
        public Calculator(int n)
        {
            number = n;
        }
        public static Calculator operator +
            (Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator(0);
            Calc3.number = Calc2.number+Calc1.number;
            return Calc3;
        }
        public void display()
        {
            Console.WriteLine($"{number}");
        }
    }
}
