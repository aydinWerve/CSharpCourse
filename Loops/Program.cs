using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForEachLoop();

            Print();

            Console.ReadLine();
        }

        private static void Print()
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is a not prime number");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if(number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Onur", "Merve", "Emre" };

            foreach (var student in students)//data çekmek için sıklıkla tercih edilmektedir.
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 15;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 16);
        }

        private static void WhileLoop()
        {
            int number = 10;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is{0}", number);
        }

        //Method haline getirme refactor = ctrl+R,ctrl+M
        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
