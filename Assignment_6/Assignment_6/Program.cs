using System;
using System.Collections;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel;

            string filepath = "/Users/minhhoang/Downloads/VAMK/WP/Assignment_6/";
            FileHandler fileHandler = new FileHandler(filepath);

            if (fileHandler.ReadHotelFromFile() != null)
            {
                hotel = fileHandler.ReadHotelFromFile();
                hotel.Rooms = fileHandler.ReadRoomsFromFile();
                hotel.Customers = fileHandler.ReadCustomersFromFile();
                Console.WriteLine("*Q*&$Q(#)Q(#*)Q*#)(Q&$()Q$");
            }
            else
            {
                Room r1 = new Room("A201", "A", "single", 20.0, "");
                Room r2 = new Room("A202", "A", "single", 22.0, "sea view");
                Room r3 = new Room("B201", "B", "double", 35.0, "");

                ArrayList rooms = new ArrayList
                {
                    r1, r2, r3
                };

                Customer c1 = new Customer("Adam", "Vaasa", "A201", new DateTime(2021, 01, 03), 2);
                Customer c2 = new Customer("Bach", "Vaasa", "A202", new DateTime(2021, 01, 03), 4);
                Customer c3 = new Customer("Minh", "Helsinki", "B201", new DateTime(2021, 01, 03), 3);

                ArrayList customers = new ArrayList
                {
                    c1, c2, c3
                };

                hotel = new Hotel("Venus Hotel", new DateTime(1989, 11, 23), "Helsinki", 4, rooms, customers);

            }

            Console.WriteLine(hotel.ToString());
            Console.WriteLine(fileHandler.WriteHotelToFile(hotel));
            Console.WriteLine(fileHandler.WriteRoomstoFile(hotel.Rooms));
            Console.WriteLine(fileHandler.WriteCustomersToFile(hotel.Customers));
        }
    }
}
