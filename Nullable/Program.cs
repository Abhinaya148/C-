using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int? TicketsOnSale = 1000;
            int AvailableTickets;
            if(TicketsOnSale==null)
            {
                AvailableTickets= 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }
            Console.WriteLine($"AvailableTickets={AvailableTickets}");
            */
            int? TicketsonSale = null;
            int AvailableTickets = TicketsonSale ?? 0;
            Console.WriteLine($"AvailableTickets={AvailableTickets}");
        }
    }
}
