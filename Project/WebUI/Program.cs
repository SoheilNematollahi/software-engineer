using Core.Repositories;
using Core.UseCases;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IFlightRepository, FlightRepository>()
            .AddSingleton<ITicketRepository, TicketRepository>()
            .AddSingleton<IFlightService, FlightService>()
            .AddSingleton<ITicketService, TicketService>()
            .BuildServiceProvider();

        
        var flightService = serviceProvider.GetService<IFlightService>();
        var ticketService = serviceProvider.GetService<ITicketService>();

        
        Console.WriteLine("Available Flights:");
        foreach (var flight in flightService.GetAvailableFlights())
        {
            Console.WriteLine($"Flight {flight.FlightId}: {flight.DepartureCity} -> {flight.ArrivalCity}, Price: {flight.Price}");
        }

        
        Console.Write("Enter Flight ID to reserve: ");
        int flightId = int.Parse(Console.ReadLine());
        Console.Write("Enter Passenger Name: ");
        string passengerName = Console.ReadLine();
        ticketService.ReserveTicket(flightId, passengerName);

        
        Console.WriteLine("\nReserved Tickets:");
        foreach (var ticket in ticketService.GetReservedTickets())
        {
            Console.WriteLine($"Ticket ID: {ticket.TicketId}, Passenger: {ticket.PassengerName}");
        }
    }
}
