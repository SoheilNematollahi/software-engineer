namespace Core.Entities
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public decimal Price { get; set; }
    }
}    


