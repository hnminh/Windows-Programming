using System;
using System.Collections;
using System.Text;

namespace Assignment_5
{
    public class Ticket
    {
        private string ticketId;
        private string passengerId;
        Flight flight;
        double price;
        private readonly double extraTax;

        public Ticket(string ticketId, string passengerId, Flight flight, double price)
        {
            this.ticketId = ticketId;
            this.passengerId = passengerId;
            this.flight = flight;
            this.price = price;

            DayOfWeek dayOfWeek = flight.Date.DayOfWeek;
            if (dayOfWeek.Equals(DayOfWeek.Saturday) || dayOfWeek.Equals(DayOfWeek.Sunday))
            {
                extraTax = 0.07;
            }
            else
            {
                extraTax = 0.05;
            }
        }

        public string TicketId
        {
            get
            {
                return ticketId;
            }
        }

        public string PassengerId
        {
            get
            {
                return passengerId;
            }
        }

        public double Price
        {
            get
            {
                return price * (1 + extraTax);
            }
        }

        public Flight Flight
        {
            get
            {
                return flight;
            }
        }

        public double GetPrice(string ticketId)
        {
            if (this.ticketId.Equals(ticketId))
            {
                return price * (1 + extraTax);
            }
            return -1;
        }

        public string CheckPassengers(ArrayList passengers)
        {
            StringBuilder result = new StringBuilder();
            foreach (Passenger passenger in passengers)
            {
                if (passenger.Id.Equals(this.passengerId))
                {
                    result.Append(passenger.ToString());
                    result.Append(this.ToString());
                    result.Append(flight.ToString());
                    result.Append("Price: " + this.Price);
                }
            }
            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Passenger ID: " + passengerId + Environment.NewLine);
            result.Append("Ticket ID: " + ticketId + Environment.NewLine);

            return result.ToString();
        }

    }
}
