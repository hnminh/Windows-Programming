using System;
using System.Collections;
using System.Text;

namespace Assignment_5
{
    public class EconomyPassenger : Passenger
    {
        protected double luggageWeight;

        public EconomyPassenger(string id, string firstName, string surname, string phoneNumber, double luggageWeight, ArrayList tickets) : base(id, firstName, surname, phoneNumber, tickets)
        {
            this.luggageWeight = luggageWeight;
        }

        public double LuggageWeight
        {
            get
            {
                return luggageWeight;
            }
        }

        public override string GetInfo(string id)
        {
            StringBuilder result = new StringBuilder();
            if (this.id.Equals(id))
            {
                result.Append(this.ToString() + Environment.NewLine);
                result.Append("Tickets: ");
                foreach (Ticket ticket in tickets)
                {
                    result.Append(ticket.TicketId + ", ");
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ID: " + id + Environment.NewLine);
            result.Append("First name: " + firstName + Environment.NewLine);
            result.Append("Surname: " + surname + Environment.NewLine);
            result.Append("Phone number: " + phoneNumber + Environment.NewLine);
            result.Append("Maximum luggage weight: " + luggageWeight + Environment.NewLine);

            return result.ToString();
        }
    }
}
