using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount+v.Message);
            var anonArray = new[]
            {
                new
                {
                    name="apple",diam=4
                },
                new
                {
                    name="grape",diam=1
                }
            };
        }
    }
}
