using System;
using System.Collections;
using System.Text;

namespace Assignment_6
{
    public class Room : IRoom
    {
        string roomNumber;
        string area;
        string type;
        double price;
        string description;

        public Room(string roomNumber, string area, string type, double price, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.price = price;
            this.description = description;
        }

        public string RoomNumber
        {
            get
            {
                return roomNumber;
            }
        }

        public string Area
        {
            get
            {
                return area;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Room number: " + roomNumber + Environment.NewLine);
            result.Append("Area: " + area + Environment.NewLine);
            result.Append("Room type: " + type + Environment.NewLine);
            result.Append("Price: " + price + Environment.NewLine);
            result.Append("Description: " + description + Environment.NewLine);

            return result.ToString();
        }
    }
}
