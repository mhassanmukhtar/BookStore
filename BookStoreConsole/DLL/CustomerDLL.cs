using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.DLL
{
    internal class CustomerDLL
    {
        internal void addCustomer(Customer newCustomer)
        {
            using (var result = new BookStoreContext())
            {
                result.customers.Add(newCustomer);
                result.SaveChanges();
                Console.WriteLine("New Customer Added...");
            }
        }

        internal List<Customer> getCustomers()
        {
            using (var result = new BookStoreContext())
            {
                return result.customers.ToList();
            }
        }

        internal void getCustomer()
        {
            using (var result = new BookStoreContext())
            {
                var customer = result.customers.FirstOrDefault(x => x.Id == 1);
                Console.WriteLine("Customer Is {0}", customer.Email);
            }
        }
        internal void updateCustomer()
        {
            using (var result = new BookStoreContext())
            {
                var customer = result.customers.FirstOrDefault(x => x.Id == 1);
                Console.WriteLine("Customer Is {0}", customer.Email);

                result.customers.Update(customer);
                result.SaveChanges();

                Console.WriteLine("Updated");
            }
        }


    }
}
