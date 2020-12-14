using System;
using System.Collections;
using System.Text;

namespace Assignment_5
{
    public class FirstClassPassenger : EconomyPassenger
    {
        private string mealMenu;
        private readonly double bonus = 0;

        public FirstClassPassenger(string id, string firstName, string surname, string phoneNumber, double luggageWeight, ArrayList tickets, string mealMenu) : base(id, firstName, surname, phoneNumber, luggageWeight, tickets)
        {
            this.mealMenu = mealMenu;
            foreach (Ticket ticket in tickets)
            {
                bonus += ticket.Price * 0.02;
            }
        }

        public string MealMenu
        {
            get
            {
                return mealMenu;
            }
        }

        public double Bonus
        {
            get
            {
                return bonus;
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
            result.Append("Bonus: " + bonus + Environment.NewLine);

            return result.ToString();
        }
    }
}
