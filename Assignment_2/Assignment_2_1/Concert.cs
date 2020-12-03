using System;
using System.Text;
using System.Globalization;

namespace Assignment_2_1
{
    public class Concert
    {

        string title, location;
        DateTime dateTime;
        double price;

        public Concert(string title, string location, DateTime dateTime, double price)
        {
            this.title = title;
            this.location = location;
            this.dateTime = dateTime;
            this.price = price;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(title + Environment.NewLine);
            result.Append("Location: " + location + Environment.NewLine);
            result.Append("Time: " + dateTime.ToString("HH:mm dd/MM/yyyy") + Environment.NewLine);
            result.Append("Price: $" + price + Environment.NewLine);

            return result.ToString();
        }

        public static bool operator <(Concert concert1, Concert concert2)
        {
            return concert1.price < concert2.price;
        }

        public static bool operator >(Concert concert1, Concert concert2)
        {
            return concert1.price > concert2.price;
        }

        public static Concert operator ++(Concert concert)
        {
            //return new Concert(concert.title, concert.location, concert.dateTime, concert.price + 5);
            concert.price += 5;
            return concert;
        }

        public static Concert operator --(Concert concert)
        {
            if (concert.price - 5 > 0)
                concert.price -= 5;
            return concert;
        }
    }
}
