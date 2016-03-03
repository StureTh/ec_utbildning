using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Menu
    {
        bool loop = true;
        private ConsoleKeyInfo userChoice;
        Register register = new Register();

        public void EnterEmployeeInfo()
        {

            
            

            Console.WriteLine("Enter your social security number");
            int enterSSN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first name:\n");
            string enterFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:\n");
            string enterLastName = Console.ReadLine();

            Console.WriteLine("Enter your hourly wage");
            int enterHWage = int.Parse(Console.ReadLine());

            Employee newEmployee= new Employee(enterSSN,enterFirstName,enterLastName,enterHWage);
            
            register.AddEmployee(newEmployee);

        }

        public void SearchEmployeeByYear()
        {
            var tempList = register.SearchSSN(Console.ReadLine()); // Här ber vi användaren söka i listan efter ett årtal
            foreach (var printSSNYear in tempList)
            {
                printSSNYear.GetSSNReadOut();
                printSSNYear.GetPersonReadOut();
            }
            Console.ReadKey();

        }

        public void UserMenu()
        {


            while (loop)
            {
                Console.WriteLine("[A]dd Emplyee\n[R]emove Employee\n[S]earch Employees by year\n[P]rint Employee\n[Q]uit Application");
                userChoice = Console.ReadKey();

                switch (userChoice.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        EnterEmployeeInfo();
                        break;

                        case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine("Enter the social security number you want to remove:\n");
                        register.RemoveEmployee(int.Parse(Console.ReadLine()));
                        break;
                        
                        case ConsoleKey.S:
                        Console.WriteLine("Enter Year to show employees");
                        
                        SearchEmployeeByYear();
                        break;

                        case ConsoleKey.P:
                        Console.Clear();
                        register.GetEmployeeListReadOut();
                        break;

                        case ConsoleKey.Q:
                        return;
                        

                }
            }

        }
    }
}
