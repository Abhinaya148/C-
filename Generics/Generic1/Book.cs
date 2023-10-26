using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_coding
{
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public override string ToString()
            {
                Console.WriteLine( $"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
            }
        }
    }

