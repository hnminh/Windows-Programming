using System;
namespace Assignment_1_2
{
    public class Customer
    {
        private string name;
        private int id;
        private string flightId;

        public Customer(string name, int id, string flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public string getFlightId()
        {
            return flightId;
        }
    }
}
