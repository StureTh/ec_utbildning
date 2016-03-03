using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var choise = "";
            var num1 = 0;
            var num2 = 0;
            var result = 0;
            while (true)
            {
                Console.WriteLine("Simpel Calculator V:1.0");


                Console.WriteLine("A. Addition\nB. Subtraction\nC. Multiplication\nD. Division\nQ. quit application");



                choise = string.Format(Console.ReadLine());

                switch (choise)
                {
                    case "a":
                        result = num1 + num2;
                        break;
                    case "b":
                        result = num1 - num2;
                        break;
                    case "c":
                        result = num1 * num2;
                        break;
                    case "d":
                        result = num1 / num2;
                        break;
                    case "q":
                        return;





                }
                Console.WriteLine("enter first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter second number");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Choise = {0}", choise);
                Console.WriteLine("The end result is:{0}", result);
            }

        }
    }
}
