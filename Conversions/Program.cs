using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        /* {
             //implicit conversion
             int i = 1000;
             float f = i;
             Console.WriteLine(f);
         }*/
        /*{
            //type casting - does not throws exception
            float f = 6738.434F;
            int i=(int)f;
            Console.WriteLine(i);
        }*/
        /*{
            //using convert class to get exceptions if cannot handle
            float f = 1234585975948.644768F;
            int i=Convert.ToInt32(f);
            Console.WriteLine(i);
        }*/
        //if a no is in string formart we use 2 methods to convert into int
        /*{
            //parse - if we know the no is a valid
            string str = "7634";
            int i=int.Parse(str);
            Console.WriteLine(i);
        }*/
        {
            //Tryparse is used to check whether it is valid no or not
            string str = "64778970";
            int Result = 0;
            bool IsConversionSuccess=int.TryParse(str, out Result);
            if(IsConversionSuccess )
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
