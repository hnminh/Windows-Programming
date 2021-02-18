using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment_9
{
    class FileHandler
    {
        string dateFormat = "MM.dd.yyyy";

        public FileHandler()
        {

        }
        public void WriteFlightsToFileSerialization(List<Flight> flights, string filename)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat(dateFormat);
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Flight>), serializingSettings);

            FileStream fileWriter = new FileStream(filename, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, flights);
            fileWriter.Close();
        }

        public List<Flight> ReadFlightsFromFileSerialization(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string jsonData = reader.ReadToEnd();
            reader.Close();

            return (List<Flight>)JsonConvert.DeserializeObject<List<Flight>>(jsonData,
                new IsoDateTimeConverter { DateTimeFormat = dateFormat });
        }

        public void WriteCustomersToFileSerialization(List<Customer> customers, string filename)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat(dateFormat);
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);

            FileStream fileWriter = new FileStream(filename, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, customers);
            fileWriter.Close();
        }

        public List<Customer> ReadCustomersFromFileSerialization(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string jsonData = reader.ReadToEnd();
            reader.Close();

            return (List<Customer>)JsonConvert.DeserializeObject<List<Customer>>(jsonData,
                new IsoDateTimeConverter { DateTimeFormat = dateFormat });
        }
    }
}
