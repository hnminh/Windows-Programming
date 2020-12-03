using System;

namespace Assignment_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[10];
            customers[0] = new Customer("Adam Levine", 0, "AY2130");
            customers[1] = new Customer("David Beckham", 1, "AY2130");
            customers[2] = new Customer("Kim Anh", 2, "AY3434");
            customers[3] = new Customer("Dan Tran", 3, "VJ2910");
            customers[4] = new Customer("Hoang Tran", 4, "AF204");
            customers[5] = new Customer("Bobby Matheson", 5, "AY2020");
            customers[6] = new Customer("Johnny Depp", 6, "AY2130");
            customers[7] = new Customer("Hoang Phan", 7, "AY3423");
            customers[8] = new Customer("Thao Tran", 8, "VJ5910");
            customers[9] = new Customer("Dat Pham", 9, "AF2044");

            Flight[] flights = new Flight[4];
            flights[0] = new Flight("AY2130", "Vaasa", "Helsinki", DateTime.Now);
            flights[1] = new Flight("AY3434", "Helsinki", "Berlin", DateTime.Now);
            flights[2] = new Flight("VJ2910", "Vaasa", "Moscow", DateTime.Now);
            flights[3] = new Flight("AF2044", "Helsinki", "Paris", DateTime.Now);

            // Adding part
            /*
            Console.WriteLine("Add a new customer");
            Console.WriteLine("Please enter customer name: ");
            string customer = Console.ReadLine();
            Console.WriteLine("Please enter customer's flightId: ");
            string flight = Console.ReadLine();
            customers[10] = new Customer(customer, 10, flight);

            Console.WriteLine("Add a new customer");
            Console.WriteLine("Please enter customer name: ");
            customer = Console.ReadLine();
            Console.WriteLine("Please enter customer's flight: ");
            flight = Console.ReadLine();
            customers[11] = new Customer(customer, 11, flight);

            Console.WriteLine("Add a new flight");
            Console.WriteLine("Please enter flightId: ");
            flight = Console.ReadLine();
            Console.WriteLine("Please enter a origin: ");
            string origin = Console.ReadLine();
            Console.WriteLine("Please enter a destination: ");
            string destination = Console.ReadLine();
            flights[4] = new Flight(flight, origin, destination, DateTime.Now);

            Console.WriteLine();
            */
            // Searching part

            Console.WriteLine("Searching part:");

            Console.WriteLine("Please enter a customer Id: ");
            int customerId = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Services.FindFlight(Services.FindCustomerById(customerId, customers), flights));

            Console.WriteLine();

            Console.WriteLine("Please enter a flight Id: ");
            string flightId = Console.ReadLine();
            Console.WriteLine(Services.FindCustomers(Services.FindFlightById(flightId, flights), customers));
        }
    }
}
