using System;
using System.Text;

namespace Assignment_6
{
    public class Customer : ICustomer
    {
        string name;
        string address;
        string roomNumber;
        DateTime arrivalDate;
        int numberOfNights;

        public Customer(string name, string address, string roomNumber, DateTime arrivalDate, int numberOfNights)
        {
            this.name = name;
            this.address = address;
            this.roomNumber = roomNumber;
            this.arrivalDate = arrivalDate;
            this.numberOfNights = numberOfNights;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public string RoomNumber
        {
            get
            {
                return roomNumber;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return arrivalDate;
            }
        }

        public int NumberOfNights
        {
            get
            {
                return numberOfNights;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Customer name: " + name + Environment.NewLine);
            result.Append("Address: " + address + Environment.NewLine);
            result.Append("Room number: " + roomNumber + Environment.NewLine);
            result.Append("Arrival date: " + arrivalDate.ToString("dd/MM/yyyy") + Environment.NewLine);
            result.Append("Length of stay: " + numberOfNights + " night(s)" + Environment.NewLine);

            return result.ToString();
        }
    }
}
