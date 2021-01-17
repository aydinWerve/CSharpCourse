using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //var result = Add2(20);
            //Console.WriteLine(result);

            int number1 = 10;
            int number2 = 20;
            var result2 = Add3(ref number1, number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1); //ref

            Console.WriteLine(Multiply(4, 2));
            Console.WriteLine(Multiply(4, 2, 5));

            Console.WriteLine(Add4(2, 4, 5, 6, 8));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        //aynı tipde bir çok parametre gönderilebilir."params" methodun parametrelerinin son parametresi olmak zorunda
        static int Add4(params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}
