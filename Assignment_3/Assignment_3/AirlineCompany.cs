using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_3
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

        public string FindFlight(string id)
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

    }
}
