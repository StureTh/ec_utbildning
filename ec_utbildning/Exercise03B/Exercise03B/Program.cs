using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03B
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            
            Console.WriteLine("Mini Calculator V:1.0");
            var num1=0;
            var num2 = 0;
            
            
            var result = 0;
            while (run)
            {
                
                Console.WriteLine("Enter first number in calculation");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number in calculation");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select an option:");
                Console.WriteLine("---------------------");
                Console.WriteLine("A) Addition (+)");
                Console.WriteLine("S) Subtraction (-)");
                Console.WriteLine("M) Multiplication (*)");
                Console.WriteLine("D) Division (/)");
                Console.WriteLine("Q) Quit application");

                var choise = Console.ReadLine().ToUpper();
                
                switch (choise)
                {
                    case "A":
                        result = num1 + num2;

                        break;
                    case "S":
                        result = num1 - num2;
                        break;
                    case "M":
                        result = num1*num2;
                        break;
                    case "D":
                        result = num1/num2;
                        break;
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("Input error. Please enter one of the following options");
                        
                        break;



                }
                
                Console.WriteLine($"Answer is:{result}");
                Console.WriteLine("Do you want  to coninue Y/N?");
                string cont = Console.ReadLine().ToUpper();
                switch (cont)
                {
                    case "Y":
                        break;
                    case "N":
                        return;

                }
                




            }
        }
    }
}
