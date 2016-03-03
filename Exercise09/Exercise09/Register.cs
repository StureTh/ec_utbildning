using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    internal class Register
    {
        private List<Employee> employeeList = new List<Employee>();


        public void AddEmployee(Employee newEmployee)
        {
            employeeList.Add(newEmployee);
        }

        public void RemoveEmployee(int sSn)
        {
            Employee tempEmployee = null;
                // Vi skapar en kopia av vårt objekt employee för att att kunna kalla på den i if statement
            foreach (var employee in employeeList)
            {
                if (employee.SSN == sSn)
                {
                    tempEmployee = employee; // säger åt vår temporära employee att den är "employee"
                }
            }
            // funktion för att ta bort employee
            employeeList.Remove(tempEmployee);
        }

        public void GetEmployeeListReadOut()
        {
            // Här skriver vi ut personerna i listan
            foreach (Employee printEmployee in employeeList)
            {
                printEmployee.GetSSNReadOut();
                printEmployee.GetPersonReadOut();
            }
        }

        public List<Employee> SearchSSN(string year)
        {
            List<Employee> employeeSSN = new List<Employee>();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].SSN.ToString().Substring(0, 2) == year)
                    // Här kollar vi om index är detsamma som user års input med hjälp av substring.
                {
                    employeeSSN.Add(employeeList[i]);
                        // Här lägger vi till index från nyaskapade listan om if'satsen ovan stämmer från orginal listan.
                }


            }
            return employeeSSN;
        }

    }
}

