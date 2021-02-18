using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_2
{
    class Flight
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public Flight(string id, string origin, string destination, DateTime date, DateTime time)
        {
            this.Id = id;
            this.Origin = origin;
            this.Destination = destination;
            this.Date = date;
            this.Time = time;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Flight id: " + Id + Environment.NewLine);
            result.Append("Origin: " + Origin + Environment.NewLine);
            result.Append("Destination: " + Destination + Environment.NewLine);
            result.Append("Time: " + Date.ToString("MM/dd/yyyy") + " " + Time.ToString("HH:mm") + Environment.NewLine);

            return result.ToString();
        }
    }
}
