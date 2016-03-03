using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lektion1
{
    class Program
    {
        static void PrintNumber(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result = result + i;
                Console.Write("{0}", i + "+"); 

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int GetNumber()
        {
            int number = 0;
            
            bool success = true;
            do
            {
                Console.WriteLine("Type any number");
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Not valid number please try again.");
                if (number < 0)
                {
                    Console.WriteLine("Number need to be possitive.");
                }
                else
                    success = false;


            } while (success);
            return number;
        }
        
        static void Main(string[] args)
        {
            #region Upp2
            //int age = 0;
            //string name = "";
            //string work = "";
            //int born = 0;
            //Console.WriteLine("Please enter your name:\n");
            //name = string.Format(Console.ReadLine());
            //Console.WriteLine("Enter your age\n");
            //born = int.Parse(Console.ReadLine());
            //age = DateTime.Now.Year - born; // Tar bort angiven ålder på nuvarande årtal.

            //Console.WriteLine("Where do you work?\n");
            //work = string.Format(Console.ReadLine());
            //string text = string.Format("Hello {0}!\n Your age is {1}, so you where born in {2} and you work at {3}", name, born, age, work);
            //Console.WriteLine(text);
            //Console.ReadLine(); 
            #endregion

            int number = GetNumber();
            PrintNumber(number);

            





        }
    }
}
