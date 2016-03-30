using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Employee employeeInfo = new Employee(19890427);
            Employee newEmployee = new Employee("Sture","Thuren",250);
            employeeInfo.PrintSSN();
            newEmployee.PrintPerson();
            Console.ReadKey();

        }
    }
}
