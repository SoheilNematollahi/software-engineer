namespace Core.Repositories
{
    public interface ITicketRepository
    {
        
        void AddTicket(Ticket ticket);
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicketById(int ticketId);
    }
}
