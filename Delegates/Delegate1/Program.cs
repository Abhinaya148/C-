using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        
        static void Main(string[] args)
            {
            Del handler = DelegateMethod;//Instantiating the delegate
            handler("Hello World");//calling the delegate
        }
    }
}
