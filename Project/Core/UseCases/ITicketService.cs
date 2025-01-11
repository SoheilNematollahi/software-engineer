namespace Core.UseCases
{
    public interface ITicketService
    {
      
        void ReserveTicket(int flightId, string passengerName);
    }
}
