using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment_9
{
    [DataContract]
    class Flight
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string AirlineCompany { get; set; }
        [DataMember]
        public string Origin { get; set; }
        [DataMember]
        public string Destination { get; set; }
        [DataMember]
        public DateTime FlightDate { get; set; }

        public Flight()
        {
            Id = "";
            AirlineCompany = "";
            Origin = "";
            Destination = "";
            FlightDate = new DateTime();
        }

        public Flight(string id, string airlineCompany, string origin, string destination, DateTime flightDate)
        {
            this.Id = id;
            this.AirlineCompany = airlineCompany;
            this.Origin = origin;
            this.Destination = destination;
            this.FlightDate = flightDate;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Flight Id: " + Id + Environment.NewLine);
            result.Append("Airline company: " + AirlineCompany + Environment.NewLine);
            result.Append("Origin: " + Origin + Environment.NewLine);
            result.Append("Destination: " + Destination + Environment.NewLine);
            result.Append("Date: " + FlightDate.ToString("MM.dd.yyyy") + Environment.NewLine);

            return result.ToString();
        }

        public string FindFlight(string flightId)
        {
            if (this.Id.Equals(flightId))
            {
                return this.ToString();
            }

            return "";
        }
    }
}
