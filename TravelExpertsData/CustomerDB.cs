﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class CustomerDB
    {
        public static Customer Authenticate(TravelExpertsContext db, string username, string password)
        {
            var customer = db.Customers.SingleOrDefault(cust => cust.Username == username 
                                                             && cust.Password == password);
            return customer; // this will either be null or an object
        }
        // Method for add new customer
        public static void Add(TravelExpertsContext db, Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public static List<Customer> GetCustomer(TravelExpertsContext db)
        {
            List<Customer> customer = db.Customers.Where(c=> c.CustomerId == 144).ToList();
            return customer;
        }
        // method for get Customer Inforatiom
        public static Customer? GetCustomerInfo(TravelExpertsContext db, int CustomerID)
        {

            Customer? customer = db.Customers.Find(CustomerID);
            return customer;
        }
        // method for updating Customer information with the new data
        public static void UpdateCustomerInfo(TravelExpertsContext db, int CustomerID, Customer newCustomer)
        {
            Customer? customer = db.Customers.Find(CustomerID);
            if (customer != null)
            {
                //customer.CustomerId = newCustomer.CustomerId;
                customer.CustFirstName = newCustomer.CustFirstName;
                customer.CustLastName = newCustomer.CustLastName;
                customer.CustAddress = newCustomer.CustAddress;
                customer.CustCity = newCustomer.CustCity;
                customer.CustProv = newCustomer.CustProv;
                customer.CustPostal = newCustomer.CustPostal;
                customer.CustCountry = newCustomer.CustCountry;
                customer.CustHomePhone = newCustomer.CustHomePhone;
                customer.CustBusPhone = newCustomer.CustBusPhone;
                customer.CustEmail = newCustomer.CustEmail;
                customer.AgentId = newCustomer.AgentId;
                //customer.Username = newCustomer.Username;
                //customer.Password = newCustomer.Password;
                db.SaveChanges();
            }
        }
        public static void ChangePassword(TravelExpertsContext db, int CustomerID, Customer newCustomer)
        {
            Customer? customer = db.Customers.Find(CustomerID);
            if (customer != null)
            {
                customer.Password = newCustomer.Password;
                db.SaveChanges();
            }
        }
    }
}
