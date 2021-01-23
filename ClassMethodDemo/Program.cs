using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            
            Customer customer = new Customer();
            
            customer.Id = 1;
            customer.Name = "faruk";
            customer.Surname = "kıllıbacak";
            customer.Phone = "0545541544";
            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.Name = "veli";
            customer2.Surname = "kıllıbacak";
            customer2.Phone = "0545541544";
            customerManager.Add(customer);
            customerManager.Add(customer2);
            var customers =customerManager.GetCustomers();
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Phone + " ");
            }
            customerManager.Delete(1);
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Phone + " ");
            }

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
       
    }
}
