using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask01
{
    class Program
    {
        public static int ShowNrOfWords(string[] arraytest) // Eftersom vi vill returna en int behöver metoden ha int och static för vi är i main.
        {
            int numberOfWords = 0;
            foreach (var hello in arraytest)
            {
                if (hello == "Hello") // Här kollar vi om variabeln hello är det samma som "Hello"och om detta stämmer ökar vi number of words med 1
                {
                    numberOfWords++;
                }

            }
            return numberOfWords;
            

        }
        static void Main(string[] args)
        {
            #region ÖxölKlöFFÖR
            //char[] vokaler = new[] {'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö'};
            //Console.WriteLine("Please typ whats on your mind:\n");

            //string test = Console.ReadLine();

            //foreach (var hehe in vokaler)
            //{
            //    test = test.Replace(hehe, 'ö');

            //}
            //Console.WriteLine(test);
            //Console.ReadKey(); 
            #endregion
            
            
            string[] arraytest = new string[] {"Hello", "Sture", "Hi", "Hello"}; // Skapar en array med 4 platser
            int showstuffs = ShowNrOfWords(arraytest); // Metoden retunerar en int som vi ger till showstuffs för att förtydliga
            Console.WriteLine(showstuffs);
            Console.ReadKey();

        }

       
    }
}
