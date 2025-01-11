namespace Core.Repositories
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAllFlights();
        Flight GetFlightById(int flightId);
    }

}
