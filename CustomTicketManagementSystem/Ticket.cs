using CustomTicketManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomTicketManagementSystem
{
    internal class Ticket
    {
        public int TicketNumber { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }

        public Ticket(int ticketNumber, string name, string service)
        {
            TicketNumber = ticketNumber;
            Name = name;
            Service = service;
        }
    }
}



