using System;
using System.Collections.Generic;

namespace Assignment_4
{
    public class AirlineCompany
    {
        private readonly string name;
        private List<Flight> flights = new List<Flight>();

        public AirlineCompany()
        {
            this.name = "Unknown";
        }

        public AirlineCompany(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Flight this[int index]
        {
            set
            {
                this.flights.Insert(index, value);
            }
            get
            {
                return this.flights[index];
            }
        }

        public int NumberOfFights
        {
            get
            {
                return flights.Count;
            }
        }

        public string DisplayAllFlights()
        {
            string res = "";
            foreach (Flight flight in flights)
            {
                res += flight.ToString();
                res += Environment.NewLine;
            }
            if (res.Equals(""))
                res += "No result" + Environment.NewLine;

            return res;
        }

        public string FindFlightById(string id)
        {
            string res = "";
            foreach (Flight flight in flights)
            {
                res += flight.FindFlight(id);
            }
            if (res.Equals(""))
                res += "No result" + Environment.NewLine;

            return res;
        }

        public string FindFlightsLessThan(ProcessAirlineDelegate processAirlineDelegate, double price)
        {
            string result = "";
            foreach (Flight flight in flights)
            {
                if (flight.CheckPrice(price))
                {
                    result += processAirlineDelegate(flight) + Environment.NewLine;
                }
            }
            return result;
        }

        public void FindFlightsLessThan(Action<Flight> flightAction, double price)
        {
            foreach (Flight flight in flights)
            {
                if (flight.CheckPrice(price))
                {
                    flightAction.Invoke(flight);
                }
            }
        }

        public string FindFlightsMoreThan(Predicate<double> flightPredicate)
        {
            foreach(Flight flight in flights)
            {
                if (flightPredicate.Invoke(flight.Price))
                {
                    return flight.ToString();
                }
            }
            return "";
        }

        public string DisplayFlightInfo(Flight flight)
        {
            return flight.ToString();
        }

        public string DisplayFlightOriginAndDestination(Flight flight)
        {
            string result = "";
            result += "Flight: " + flight.Id + Environment.NewLine;
            result += "From " + flight.Origin + " to " + flight.Destination + Environment.NewLine;
            return result;
        }

        public void DoAction(Action<double> someAction)
        {
            someAction.Invoke(100);
        }
    }
}
