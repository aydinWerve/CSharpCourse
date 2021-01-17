using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tip güvenli bir çalışma yoksa yani o array içinde string integer türünden karışık olarak veriler olacaksa ArrayList kullanılır.
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]); //hata verir boyle bir key bulunmadığından

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("book")); //bool
            Console.WriteLine(dictionary.ContainsKey("glass"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara")); //kontrol eder

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FistName = "Merve" });
            //customers.Add(new Customer { Id = 2, FistName = "Emre" });

            List<Customer> customers = new List<Customer>
            {
                      new Customer { Id = 1, FistName = "Merve" },
                      new Customer { Id = 2, FistName = "Emre" }
            };

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);


            var customer2 = new Customer
            {
                Id = 3,
                FistName = "Onur"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4 ,FistName="Fatih"},
                new Customer{Id=5 ,FistName="Aydın" }
            });

            //customers.Clear();

            customers.RemoveAll(c => c.FistName == "Merve"); //Merve yı bul ve sil

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FistName);
            }

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FistName { get; set; }
    }
}
