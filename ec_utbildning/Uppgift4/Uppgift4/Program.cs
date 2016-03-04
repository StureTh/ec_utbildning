using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            // While version
            //int number;
            //int result = 0;
            //int i = 0;
            //Console.WriteLine("Type any number");
            //number=Int32.Parse(Console.ReadLine());
            //while (i < number)
            //{
            //    i++;
            //    result = result + i;
            //    Console.Write("{0}",i+ "+");


            //}
            //Console.WriteLine(result);
            //Console.ReadKey(); 

            // Do While version
            int number;
            int result = 0;
            int i = 0;
            bool success = true;
            do
            {


                Console.WriteLine("Type any number");
                while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("not a valid number");
                if (number <0)
                {
                    Console.WriteLine("Number need to be positive");
                }
                else
                {
                    success = false;
                }
            } while (success);
            
             
            do
            {
                i++;
                result = result + i;
                Console.Write("{0}",i+"+");
            } while (i<number);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
