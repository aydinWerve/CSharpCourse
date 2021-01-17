using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExcetionIntro();
            //TryCatch();
            //ActionDemo();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }


        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private static void Find()
        {
            List<string> students = new List<string>
            {
                "merve",
                "emre",
                "onur"
            };

            if (!students.Contains("fatih"))
            {
                //throw new RecordNotFoundException();
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExcetionIntro()
        {
            try
            {
                string[] student = new string[3]
{
                "merve",
                "emre",
                "onur"
};

                student[3] = "aydin";
            }
            catch (IndexOutOfRangeException exception)
            {

                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {

                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}

