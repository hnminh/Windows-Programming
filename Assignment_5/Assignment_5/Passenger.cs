using System;
using System.Collections;
using System.Text;

namespace Assignment_5
{
    public class Passenger
    {
        protected string id;
        protected string firstName;
        protected string surname;
        protected string phoneNumber;
        protected ArrayList tickets;

        public Passenger(string id, string firstName, string surname, string phoneNumber, ArrayList tickets)
        {
            this.id = id;
            this.firstName = firstName;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.tickets = tickets;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public virtual string GetInfo(string id)
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

            return result.ToString();
        }
    }
}
