using System;
using System.Text;
using System.Globalization;

namespace Assignment_3
{
    public class Flight
    {
        private string id;
        private string origin;
        private string destination;
        private DateTime date;
        private double price;

        public Flight(string id, string origin, string destination, DateTime date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
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

        public double Price
        {
            get
            {
                return price;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Flight: " + this.id + Environment.NewLine);
            result.Append("From " + this.origin + " to " + destination + Environment.NewLine);
            result.Append("Time: " + this.date.ToString("HH:mm dd/MM/yyyy") + Environment.NewLine);
            result.Append("Price: " + this.price + Environment.NewLine);
            return result.ToString();
        }

        public string FindFlight(string id)
        {
            StringBuilder result = new StringBuilder();
            if (this.id.Equals(id))
            {
                result.Append("Flight: " + this.id + Environment.NewLine);
                result.Append("From " + this.origin + " to " + destination + Environment.NewLine);
                result.Append("Time: " + this.date.ToString("HH:mm dd/MM/yyyy") + Environment.NewLine);
                result.Append("Price: " + this.price + Environment.NewLine);
            }
            return result.ToString();
        }
    }
}
