namespace Core.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }        
        public int FlightId { get; set; }        
        public string PassengerName { get; set; } 
        public DateTime DateOfPurchase { get; set; } 
    }
}
