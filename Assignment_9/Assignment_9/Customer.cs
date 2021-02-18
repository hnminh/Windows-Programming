using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment_9
{
    [DataContract]
    class Customer
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Flight { get; set; }

        public Customer()
        {
            this.Id = "";
            this.Name = "";
            this.Flight = "";
        }

        public Customer(string id, string name, string flight)
        {
            this.Id = id;
            this.Name = name;
            this.Flight = flight;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Customer Id: " + Id + Environment.NewLine);
            result.Append("Name: " + Name + Environment.NewLine);
            result.Append("Flight: " + Flight + Environment.NewLine);

            return result.ToString();
        }

        public string FindCustomer(string customerId)
        {
            if (this.Id.Equals(customerId))
            {
                return this.ToString();
            }
            return "";
        }
    }
}
