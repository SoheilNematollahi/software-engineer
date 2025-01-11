namespace Core.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly List<Flight> _flights = new List<Flight>
        {
            new Flight { FlightId = 1, FlightName = "Flight 101", DepartureCity = "New York", ArrivalCity = "London", DepartureDate = DateTime.Now.AddDays(1), Price = 500 },
            new Flight { FlightId = 2, FlightName = "Flight 102", DepartureCity = "Los Angeles", ArrivalCity = "Tokyo", DepartureDate = DateTime.Now.AddDays(2), Price = 700 }
        };

        public IEnumerable<Flight> GetAllFlights()
        {
            return _flights;
        }

        public Flight GetFlightById(int flightId)
        {
            return _flights.FirstOrDefault(f => f.FlightId == flightId);
        }
    }

}
