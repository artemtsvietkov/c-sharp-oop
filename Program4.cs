using System;
using System.Collections.Generic;

interface IBookable
{
    bool BookSeat(Passenger passenger);
    bool CancelSeat(Passenger passenger);
}

class Passenger
{
    public string Name { get; }
    public int Age { get; }
    public string PassportNumber { get; }

    public Passenger(string name, int age, string passportNumber)
    {
        Name = name;
        Age = age;
        PassportNumber = passportNumber;
    }
}

class Flight : IBookable
{
    public string FlightNumber { get; }
    public string Destination { get; }
    public int AvailableSeats { get; private set; }
    private List<Passenger> bookedPassengers;

    public Flight(string flightNumber, string destination, int availableSeats)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        AvailableSeats = availableSeats;
        bookedPassengers = new List<Passenger>();
    }

    public bool BookSeat(Passenger passenger)
    {
        if (AvailableSeats > 0)
        {
            bookedPassengers.Add(passenger);
            AvailableSeats--;
            Console.WriteLine($"{passenger.Name} har bokat en biljett till {Destination}.");
            return true;
        }
        else
        {
            Console.WriteLine("Inga lediga platser kvar!");
            return false;
        }
    }

    public bool CancelSeat(Passenger passenger)
    {
        if (bookedPassengers.Remove(passenger))
        {
            AvailableSeats++;
            Console.WriteLine($"{passenger.Name} har avbokat sin biljett.");
            return true;
        }
        else
        {
            Console.WriteLine("Passageraren har ingen bokad biljett.");
            return false;
        }
    }

    public void ShowFlightInfo()
    {
        Console.WriteLine($"Flygnummer: {FlightNumber}, Destination: {Destination}, Lediga säten: {AvailableSeats}");
    }
}

class Program4
{
    static void Main()
    {
        Flight flight = new Flight("SK123", "Stockholm", 3);
        flight.ShowFlightInfo();

        Passenger p1 = new Passenger("Artem", 28, "A12345");
        Passenger p2 = new Passenger("Dmytro", 35, "B67890");
        Passenger p3 = new Passenger("Daniil", 22, "C13579");
        Passenger p4 = new Passenger("Kamran", 40, "D24680");

        flight.BookSeat(p1);
        flight.BookSeat(p2);
        flight.BookSeat(p3);
        flight.BookSeat(p4);

        flight.ShowFlightInfo();

        flight.CancelSeat(p2);
        flight.ShowFlightInfo();
    }
}
