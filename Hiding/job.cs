using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiding
{
    public class Job
    {
        public virtual void  display()
        {
            Console.WriteLine("super  class displaying");
        }
            //public int id;
            //public string name;
            //public string salary;
    
        
    }
        
    
     class roles : Job 
    {
        public override void display()
    {
        Console.WriteLine("Sub class this is called");
    }
    }
}
