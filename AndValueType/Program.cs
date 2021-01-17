using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;
        }
    }
}
