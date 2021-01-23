using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();
        public void Add(Customer customer)
        {
            customerList.Add(customer);  
        }
        public void Delete(int Id)
        {
            var customer = GetCustomerById(Id);
            customerList.Remove(customer);
        }
        public List<Customer> GetCustomers()
        {
            return customerList;
        }
        public Customer GetCustomerById(int Id)
        {
            var customer = customerList.FirstOrDefault(p => p.Id==Id);
            if (customer==null)
            {
                Console.WriteLine("Id yok");
                return null;
            }
            else
            {
                return customer;
            }
        }
    }
}
