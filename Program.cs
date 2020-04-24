using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Programming_CSharp
{
    // Simple customer class
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
    // Main program
    public class Tester
    {
        static void Main()
        {
            List<Customer> customers = CreateCustomerList();
            var customerXml = new XDocument();
            var rootElem = new XElement("Customers");
            customerXml.Add(rootElem);
            foreach (Customer customer in customers)
            {
                // Create new element representing the customer object.
                var customerElem = new XElement("Customer");
                // Add element representing the FirstName property
                // to the customer element.
                var firstNameElem = new XElement("FirstName", customer.FirstName);
                customerElem.Add(firstNameElem);
                // Add element representing the LastName property
                // to the customer element.
                var lastNameElem = new XElement("LastName", customer.LastName);
                customerElem.Add(lastNameElem);
                // Add element representing the EmailAddress property
                // to the customer element.
                var emailAddress = new XElement("EmailAddress", customer.EmailAddress);
                customerElem.Add(emailAddress);
                // Finally add the customer element to the XML document
                rootElem.Add(customerElem);
            }
            Console.WriteLine(customerXml.ToString());
            Console.Read();
        }
        // Create a customer list with sample data
        private static List<Customer> CreateCustomerList()
        {
            List<Customer> customers = new List<Customer>
            {new Customer { FirstName = "Orlando",LastName = "Gee",EmailAddress = "orlando0@hotmail.com"},
            new Customer { FirstName = "Keith",LastName = "Harris",EmailAddress = "keith0@hotmail.com" },
                new Customer { FirstName = "Donna",LastName = "Carreras",EmailAddress = "donna0@hotmail.com" },
                new Customer { FirstName = "Janet",LastName = "Gates",EmailAddress = "janet1@hotmail.com" },
                new Customer { FirstName = "Lucy",LastName = "Harrington",EmailAddress = "lucy0@hotmail.com" }};
            return customers;
        }
    }
}

