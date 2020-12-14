using System;
using System.Text;

namespace Assignment_5
{
    public class Flight
    {
        private string id;
        private string origin;
        private string destination;
        private DateTime date;

        public Flight(string id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Origin
        {
            get
            {
                return origin;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Flight: " + this.id + Environment.NewLine);
            result.Append("From " + this.origin + " to " + destination + Environment.NewLine);
            result.Append("Time: " + this.date.ToString("HH:mm dd/MM/yyyy") + Environment.NewLine);
            return result.ToString();
        }

        public string FlightInfo(string id)
        {
            if (this.id.Equals(id))
            {
                return this.ToString();
            }
            return "";
        }

    }
}
