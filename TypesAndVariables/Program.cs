using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'M';
            double number5 = 10.4;
            decimal number6 = 10;

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);

            Console.WriteLine("Character is: {0}", character);
            Console.WriteLine("Character is: {0}", (int)character);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);


            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Staurday,Sunday
    }
}
