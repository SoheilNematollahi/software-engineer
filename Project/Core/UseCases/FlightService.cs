namespace Core.UseCases
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public IEnumerable<Flight> GetAvailableFlights()
        {
            return _flightRepository.GetAllFlights();
        }
    }

    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IFlightRepository _flightRepository;

        public TicketService(ITicketRepository ticketRepository, IFlightRepository flightRepository)
        {
            _ticketRepository = ticketRepository;
            _flightRepository = flightRepository;
        }

        public void ReserveTicket(int flightId, string passengerName)
        {
            var flight = _flightRepository.GetFlightById(flightId);
            if (flight == null)
                throw new Exception("Flight not found");

            var ticket = new Ticket
            {
                FlightId = flightId,
                PassengerName = passengerName,
                DateOfPurchase = DateTime.Now
            };

            _ticketRepository.AddTicket(ticket);
        }
    }
}
