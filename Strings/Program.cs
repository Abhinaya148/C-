using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to dot net.";
            Console.WriteLine(str);
            char[] chars = { 'W', 'O', 'R', 'D' };
            string str1=new string(chars);
            Console.WriteLine(str1);
            string str2 = new string('c',6);
            Console.WriteLine(str2);

            StringBuilder sb = new StringBuilder("ABC",20);
            sb.Append(new char[] {'D','E','F'});
            sb.AppendFormat("GHI{0}{1}", 'J', 'K');
            Console.WriteLine(sb.ToString());
        }
    }
}
