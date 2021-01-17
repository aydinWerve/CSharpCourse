using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(10);
            //customerManager.List();

            //Product product = new Product { ID = 1, Name = "Elma" };
            //Product product1 = new Product(2, "Armut");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

           // PersonManager personManager = new PersonManager("Product");
            //personManager.Add();

            //Teacher.Number = 4;

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count) //ctor çift tab
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product() //default constructor
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggerd to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loggerd to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }
}
