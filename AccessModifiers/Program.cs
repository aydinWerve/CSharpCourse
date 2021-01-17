using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; }

        public void Save()
        {


        }

        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save2()
        {


        }
    }

    public class Course //class ın defaultu internal dır. Bir class private ve protected olamaz. Fakat içiçe classlarda private olabilir.
    {
        public string Name { get; set; }
    }
}