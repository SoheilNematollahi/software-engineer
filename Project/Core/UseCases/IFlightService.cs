namespace Core.UseCases
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetAvailableFlights();
    }

    public interface ITicketService
    {
        void ReserveTicket(int flightId, string passengerName);
    }
}
