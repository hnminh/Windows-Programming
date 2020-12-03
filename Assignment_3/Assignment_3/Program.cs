using System;

namespace Assignment_3
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

            Console.WriteLine("-------------------------------");

            // testing the GET property
            Console.WriteLine(airline.Name);
            // testing FindFlight() method
            Console.WriteLine(airline.FindFlight("VN0001"));
            // testing with no result
            Console.WriteLine(airline.FindFlight("VN0000"));
            // testing with GET by index
            Console.WriteLine(airline[2]);

            Console.WriteLine(airline.DisplayAllFlights());
        }
    }
}
