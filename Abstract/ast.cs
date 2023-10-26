using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class ast
    {
        internal abstract class TransportMode
        {
            public abstract string Mode(string name);  // abstract method signature
            public void show()
            {
                Console.WriteLine("From Abstract class but a non abstract method");
            }
        }

        internal class RoadLines : TransportMode
        {
            // implementing abstract method
            public override string Mode(string name)
            {
                // throw new NotImplementedException();
                return string.Format($"Road Line Now using {name}");
            }
        }
    }
}
