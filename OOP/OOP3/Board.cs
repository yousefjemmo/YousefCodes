using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Board
    {

        private List<Ticket> Tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }

        public List<Ticket> GetTicketsByState(State State)
        {
            List<Ticket> result = new List<Ticket>();
            foreach (var ticket in Tickets)
            {  
                if (State == ticket.GetState())
                {
                    result.Add(ticket);
                }               
            }
            return result;
        }

        public void RemoveAllFinishedTickets()
        {   
            
            var ticketsDone = GetTicketsByState(State.Done);
            foreach (var ticket in ticketsDone)
            {
                Tickets.Remove(ticket);
            }

            Console.WriteLine($"{ticketsDone.Count} has been deleted.");
            
            
        }
    }
}
