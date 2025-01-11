namespace Core.Repositories
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

       
        public Ticket GetTicketById(int ticketId)
        {
            return _tickets.FirstOrDefault(t => t.TicketId == ticketId);
        }
    }
}
