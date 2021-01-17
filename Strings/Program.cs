using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Merve Aydın";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Aydın Merve";

            bool result3 = sentence.EndsWith("e");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name"); //bulamadığında -1 döndürür
            var result6 = sentence.IndexOf(" "); //aramaya baştan başlar
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar

            var result8 = sentence.Insert(0,"Hello, "); //cümlenin sıfırıncı karakterinden itibaren "Hello, " ekle

            var result9 = sentence.Substring(3);
            var result10 = sentence.Substring(3,4);

            var result11 = sentence.ToLower();

            var result12 = sentence.Replace(" ","-");

            var result13 = sentence.Remove(2,5);

            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Artvin";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(result);
        }
    }
}
