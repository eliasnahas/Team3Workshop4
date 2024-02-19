using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class CustomerDB
    {
        // method for checking username and password
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        // Code By Jack
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
                db.SaveChanges();
            }
        }
        // method for changing password
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
