using System;
using System.Text;

namespace Assignment_1_2
{
    public class Services
    {

        public static Customer FindCustomerById(int customerId, Customer[] customers)
        {
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].getId().Equals(customerId))
                {
                    return customers[i];
                }
            }
            return null;
        }

        public static string FindFlight(Customer customer, Flight[] flights)
        {
            StringBuilder sb = new StringBuilder();
            if (customer != null)
            {
                string result = "Customer: " + customer.getName() + " (Id: " + customer.getId().ToString() + ")" + Environment.NewLine;
                for (int i = 0; i < flights.Length; i++)
                {
                    if (flights[i].getId().Equals(customer.getFlightId()))
                    {
                        result += flights[i].toString();
                    }
                }
                return result;
            }
            else
            {
                return "Customer not found";
            }
        }

        public static Flight FindFlightById(string flightId, Flight[] flights)
        {
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].getId().Equals(flightId))
                {
                    return flights[i];
                }
            }
            return null;
        }

        public static string FindCustomers(Flight flight, Customer[] customers)
        {
            if (flight != null)
            {
                string result = flight.toString() + Environment.NewLine + "Passengers: " + Environment.NewLine;
                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i].getFlightId().Equals(flight.getId()))
                    {
                        result += customers[i].getName() + " (Id: " + customers[i].getId().ToString() + ")" + Environment.NewLine;
                    }
                }
                return result;
            }
            else
            {
                return "Flight not found";
            }
        }
    }
}
