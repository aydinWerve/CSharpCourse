using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FisrtName = "Merve";
            customer.LastName = "Aydın";
            customer.City = "Artvin";

            Customer customer2 = new Customer 
            {
                Id = 2,
                FisrtName = "Emre", 
                LastName = "Aydın", 
                City = "Artvin"
            };

            Console.WriteLine(customer2.FisrtName);

            Console.ReadLine();
        }
    }
}
