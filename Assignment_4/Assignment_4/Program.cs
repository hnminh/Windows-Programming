using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airline = new AirlineCompany("Vietnam Airlines");

            // SET properties
            airline[0] = new Flight("VN0001", "Hanoi", "Da Nang", new DateTime(2020, 11, 10, 19, 0, 0), 50);
            airline[1] = new Flight("VN0310", "Hanoi", "Hai Phong", new DateTime(2020, 11, 10, 20, 0, 0), 30);
            airline[2] = new Flight("VN1324", "Ho Chi Minh City", "Da Nang", new DateTime(2020, 11, 10, 5, 0, 0), 40.3);
            airline[3] = new Flight("VN0004", "Hanoi", "Helsinki", new DateTime(2020, 06, 05, 13, 0, 0), 1200);
            airline[4] = new Flight("VN0005", "Hanoi", "Berlin", new DateTime(2020, 06, 01, 17, 0, 0), 1200);

            Console.WriteLine("************ GENERAL PART ************");

            // testing the GET property
            Console.WriteLine(airline.Name);
            // testing FindFlight() method
            Console.WriteLine(airline.FindFlightById("VN0001"));
            // testing with no result
            Console.WriteLine(airline.FindFlightById("VN0000"));
            // testing with GET by index
            Console.WriteLine(airline[2]);

            Console.WriteLine(airline.DisplayAllFlights());


            Console.WriteLine("************ DELEGATE PART ************");

            ProcessAirlineDelegate airlineDelegate1 = new ProcessAirlineDelegate(airline.DisplayFlightInfo);
            Console.WriteLine(airline.FindFlightsLessThan(airlineDelegate1, 40));

            ProcessAirlineDelegate airlineDelegate2 = new ProcessAirlineDelegate(airline.DisplayFlightOriginAndDestination);
            Console.WriteLine(airline.FindFlightsLessThan(airlineDelegate2, 50));

            Console.WriteLine("************ ACTION PART ************");

            Action<Flight> flightAction = x => Console.WriteLine(x.ToString());
            double price = 100;
            airline.FindFlightsLessThan(flightAction, price);


            Console.WriteLine("************ PREDICATE PART ************");

            Predicate<double> flightPredicate = x => (x > 250);
            Console.WriteLine("First flight that price is greater than 250: ");
            Console.WriteLine(airline.FindFlightsMoreThan(flightPredicate));

        }
    }
}
