using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Merve";
            students[1] = "Emre";
            students[2] = "Onur";

            string[] students2 = new string[]
            { 
                "Onur", 
                "Merve", 
                "Emre"
            };

            string[] students3 = new[] { "Onur", "Merve", "Emre" };

            string[] students4 = { "Onur", "Merve", "Emre" };

            //"foreach" bir array ı gezmek için kullanılır.
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("  ");

            string[,] regions = new string[5, 3]
                {
                    {"İstanbul","Çanakkale","Bursa" },
                    { "Aksaray","Kayseri","Nevşehir" },
                    { "Artvin","Trabzon","Ordu" },
                    { "İzmir","Muğla","Manisa" },
                    { "Antalya","Manisa","Muğla" }
                 };

            Console.WriteLine(" //////////// ");

            Console.WriteLine(regions.GetUpperBound(0)); // 4
            Console.WriteLine(regions.GetUpperBound(1)); // 2

            Console.WriteLine(" //////////// ");

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("*****************");
            }

            Console.ReadLine();
        }
    }
}
