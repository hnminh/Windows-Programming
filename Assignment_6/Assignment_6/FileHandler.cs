using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Assignment_6
{
    public class FileHandler
    {
        string filepath;

        public FileHandler(string filepath)
        {
            this.filepath = filepath;
        }

        public string WriteHotelToFile(Hotel hotel)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filepath + "hotel.txt", FileMode.Create));
                binaryWriter.Write(hotel.Name);
                binaryWriter.Write(hotel.ConstructionDate.ToString());
                binaryWriter.Write(hotel.Address);
                binaryWriter.Write(hotel.NumberOfStars);
                binaryWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filepath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + this.filepath);
            }

            FileInfo fileInfo = new FileInfo(filepath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return result.ToString();
        }

        public string WriteRoomstoFile(ArrayList rooms)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filepath + "rooms.txt", FileMode.Create));
                foreach (Room room in rooms)
                {
                    binaryWriter.Write(room.RoomNumber);
                    binaryWriter.Write(room.Area);
                    binaryWriter.Write(room.Type);
                    binaryWriter.Write(room.Price);
                    binaryWriter.Write(room.Description);
                }
                binaryWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filepath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + this.filepath);
            }

            FileInfo fileInfo = new FileInfo(filepath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return result.ToString();
        }

        public string WriteCustomersToFile(ArrayList customers)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filepath + "customers.txt", FileMode.Create));
                foreach (Customer customer in customers)
                {
                    binaryWriter.Write(customer.Name);
                    binaryWriter.Write(customer.Address);
                    binaryWriter.Write(customer.RoomNumber);
                    binaryWriter.Write(customer.ArrivalDate.ToString());
                    binaryWriter.Write(customer.NumberOfNights);
                }
                binaryWriter.Close();
            }
            catch (FileNotFoundException)
            {
                result.Append(filepath + " not found!");
            }
            catch (IOException)
            {
                result.Append("Error writing to file: " + this.filepath);
            }

            FileInfo fileInfo = new FileInfo(filepath);

            if (fileInfo.Exists)
                result.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return result.ToString();
        }

        public Hotel ReadHotelFromFile()
        {
            string hotelName = "";
            DateTime constructionDate = new DateTime();
            string address = "";
            int numberOfStars;
            ArrayList rooms = new ArrayList();
            ArrayList customers = new ArrayList();

            try
            {
                BinaryReader binaryReader = new BinaryReader(new FileStream(filepath + "hotel.txt", FileMode.Open));
                hotelName = binaryReader.ReadString();
                constructionDate = DateTime.Parse(binaryReader.ReadString());
                address = binaryReader.ReadString();
                numberOfStars = binaryReader.ReadInt32();
            }
            catch (Exception)
            {
                return null;
            }

            return new Hotel(hotelName, constructionDate, address, numberOfStars, rooms, customers);
        }

        public ArrayList ReadRoomsFromFile()
        {
            string roomNumber;
            string area;
            string type;
            double price;
            string description;
            ArrayList rooms = new ArrayList();

            try
            {
                BinaryReader binaryReader = new BinaryReader(new FileStream(filepath + "rooms.txt", FileMode.Open));
                for (; ; )
                {
                    roomNumber = binaryReader.ReadString();
                    area = binaryReader.ReadString();
                    type = binaryReader.ReadString();
                    price = binaryReader.ReadDouble();
                    description = binaryReader.ReadString();

                    rooms.Add(new Room(roomNumber, area, type, price, description));
                }
            }
            catch (Exception)
            {

            }

            return rooms;
        }

        public ArrayList ReadCustomersFromFile()
        {
            string customerName;
            string customerAddress;
            string customerRoomNumber;
            DateTime arrivalDate;
            int numberOfNights;
            ArrayList customers = new ArrayList();

            try
            {
                BinaryReader binaryReader = new BinaryReader(new FileStream(filepath + "customers.txt", FileMode.Open));
                for (; ; )
                {
                    customerName = binaryReader.ReadString();
                    customerAddress = binaryReader.ReadString();
                    customerRoomNumber = binaryReader.ReadString();
                    arrivalDate = DateTime.Parse(binaryReader.ReadString());
                    numberOfNights = binaryReader.ReadInt32();

                    customers.Add(new Customer(customerName, customerAddress, customerRoomNumber, arrivalDate, numberOfNights));
                }
            }
            catch (Exception)
            {

            }

            return customers;
        }
    }
}
