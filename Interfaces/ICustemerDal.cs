using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustemerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustemerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql server added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql server deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql server updated");
        }
    }

    class OracleCustomerDal : ICustemerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustemerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
