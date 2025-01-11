using Core.Entities;
using Core.Repositories;
using System.Collections.Generic;

namespace Infrastructure.Data
{
    public class TicketRepository : ITicketRepository
    {
        private readonly List<Ticket> _tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _tickets;
        }
    }
}
