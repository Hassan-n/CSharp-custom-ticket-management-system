using System.Net.Sockets;

namespace CustomTicketManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the data structure to store tickets
            Queue<Ticket> tickets = new Queue<Ticket>();

            // Start processing student requests
            while (true)
            {
                Console.WriteLine("Enter student name or 'exit' to quit:");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break; // Exit the loop if the user enters 'exit'
                }

                Console.WriteLine("Enter service required:");
                string service = Console.ReadLine();

                // Generate a unique ticket number for the student
                int ticketNumber = tickets.Count + 1;

                // Create a new ticket object and add it to the data structure
                Ticket newTicket = new Ticket(ticketNumber, name, service);
                tickets.Enqueue(newTicket);

                Console.WriteLine($"Ticket {ticketNumber} created for {name} ({service})");
            }

            // Process resolved tickets
            while (tickets.Count > 0)
            {
                // Retrieve the ticket at the front of the data structure without removing it
                Ticket currentTicket = tickets.Peek();
                Console.WriteLine($"Processing ticket {currentTicket.TicketNumber} for {currentTicket.Name} ({currentTicket.Service})");

                // Remove the ticket from the data structure
                tickets.Dequeue();
                Console.WriteLine($"Ticket {currentTicket.TicketNumber} resolved for {currentTicket.Name} ({currentTicket.Service})");
            }
        }
    }
}

 