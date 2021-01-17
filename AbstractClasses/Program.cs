using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle(); // abstract classlar newlenemez.
            database.Add();
            database.Delete();

            Database database2 = new SqlServer(); // abstract classlar newlenemez.
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add() //tamamlanmış method.
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); //tamamlanmamış method.
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
