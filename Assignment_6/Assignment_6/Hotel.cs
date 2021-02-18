using System;
using System.Collections;
using System.Text;

namespace Assignment_6
{
    public class Hotel : IHotel
    {
        string name;
        DateTime constructionDate;
        string address;
        int numberOfStars;
        ArrayList rooms;
        ArrayList customers;

        public Hotel(string name, DateTime constructionDate, string address, int numberOfStars, ArrayList rooms, ArrayList customers)
        {
            this.name = name;
            this.constructionDate = constructionDate;
            this.address = address;
            this.numberOfStars = numberOfStars;
            this.rooms = rooms;
            this.customers = customers;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public DateTime ConstructionDate
        {
            get
            {
                return constructionDate;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public int NumberOfStars
        {
            get
            {
                return numberOfStars;
            }
        }

        public ArrayList Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
            }
        }

        public ArrayList Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Hotel name: " + name + Environment.NewLine);
            result.Append("Construction date: " + constructionDate.ToString("dd/MM/yyyy") + Environment.NewLine);
            result.Append("Address: " + address + Environment.NewLine);
            result.Append("Number of stars: " + numberOfStars + Environment.NewLine);
            result.Append(Environment.NewLine + "---------------" + Environment.NewLine);
            result.Append("Rooms: " + Environment.NewLine);
            foreach (Room room in rooms)
            {
                result.Append(room.ToString() + Environment.NewLine);
            }
            result.Append(Environment.NewLine + "---------------" + Environment.NewLine);
            result.Append("Customers: " + Environment.NewLine);
            foreach (Customer customer in customers)
            {
                result.Append(customer.ToString() + Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
