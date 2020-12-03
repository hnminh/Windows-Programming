using System;
using System.Globalization;

namespace Assignment_1_2
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

        public string getId()
        {
            return id;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestination()
        {
            return destination;
        }

        public DateTime getDate()
        {
            return date;
        }

        public string toString()
        {
            string result = "";
            result += "Flight: " + this.id + "\n";
            result += "From " + this.origin + " to " + destination + "\n";
            result += "Time: " + this.date.ToString(new CultureInfo("fi-FI"));
            return result;
        }
    }
}
