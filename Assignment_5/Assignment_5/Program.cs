using System;
using System.Collections;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // init some flights
            Flight HANtoSGN = new Flight("VN0001", "Hanoi", "Ho Chi Minh City", new DateTime(2020, 12, 10, 23, 50, 00));
            Flight HANtoDAD = new Flight("VN0002", "Hanoi", "Da Nang", new DateTime(2020, 12, 12, 04, 15, 00));
            Flight HANtoHEL = new Flight("VN1001", "Hanoi", "Helsinki", new DateTime(2020, 12, 13, 06, 00, 00));

            // init some tickets
            Ticket ticketHANtoSGN1 = new Ticket("VN0001_001", "P1", HANtoSGN, 100);
            Ticket ticketHANtoSGN2 = new Ticket("VN0001_002", "P2", HANtoSGN, 500);

            Ticket ticketHANtoDND1 = new Ticket("VN0002_001", "P1", HANtoDAD, 80);

            Ticket ticketHANtoHEL1 = new Ticket("VN1001_001", "P3", HANtoHEL, 4000);
            Ticket ticketHANtoHEL2 = new Ticket("VN1001_002", "P2", HANtoHEL, 1000);

            // some arraylist here
            ArrayList ticketsP1 = new ArrayList
            {
                ticketHANtoSGN1,
                ticketHANtoDND1
            };

            ArrayList ticketsP2 = new ArrayList
            {
                ticketHANtoSGN2,
                ticketHANtoHEL2
            };

            ArrayList ticketsP3 = new ArrayList
            {
                ticketHANtoHEL1
            };

            // init some passengers
            Passenger p1 = new Passenger("P1", "Minh", "Hoang", "123456", ticketsP1);
            Passenger p2 = new EconomyPassenger("P2", "Hoang", "Hoang", "098765678", 23, ticketsP2);
            Passenger p3 = new FirstClassPassenger("P3", "Joe", "Millionare", "0954345", 46, ticketsP3, "beefsteak");

            ArrayList passengers = new ArrayList
            {
                p1,
                p2,
                p3
            };

            Console.WriteLine("*********** Check Passengers ArrayList ***********");
            Console.WriteLine(ticketHANtoHEL1.CheckPassengers(passengers));
            Console.WriteLine();
            Console.WriteLine(ticketHANtoSGN1.CheckPassengers(passengers));
            Console.WriteLine();

            Console.WriteLine("*********** Check Passenger GetInfo() ***********");
            Console.WriteLine(p1.GetInfo("P1"));
            Console.WriteLine(p2.GetInfo("P2"));

            Console.WriteLine("*********** Check EconomyPassenger GetInfo() ***********");
            Console.WriteLine(p2.GetInfo("P2"));

            Console.WriteLine("*********** Check FirstClassPassenger GetInfo() ***********");
            Console.WriteLine(p3.GetInfo("P3"));
        }
    }
}
