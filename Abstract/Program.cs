using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract.ast;

namespace Abstract
{
    internal class Programz
    {
        static void Main(string[] args)
        {
            RoadLines roadLines = new RoadLines();
            Console.WriteLine(roadLines.Mode("Cab"));
            roadLines.show();
        }
    }
}
