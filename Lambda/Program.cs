using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate int Del(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Del del = (x, y) => x * y;
            Del del1= (x, y) => x + y;
            Del del2 = (x, y) => x - y;
            int result = del(6, 9);
            int result1=del1(6, 9);
            int result2 = del2(6, 9);
            Console.WriteLine($"Multiply={result}");
            Console.WriteLine($"Add={result1}");
            Console.WriteLine($"Sub={result2}");
        }
    }
}
