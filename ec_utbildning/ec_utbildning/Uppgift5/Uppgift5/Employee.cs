using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    class Employee
    {
        private string fName;
        private string lName;
        private int sSN;
        private int hWage;
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        

        public int SSN
        {
            get { return sSN; }
            set { sSN = value; }
        }
        

        public int HWage
        {
            get { return hWage; }
            set { hWage = value; }
        }


        public Employee(string fName="",string lName="",int hWage=0)
        {
            this.fName = fName;
            this.lName = lName;
            this.hWage = hWage;


        }

        public Employee(int sSN=0)
        {
            this.sSN = sSN;
        }

        public void PrintPerson()
        {
            Console.WriteLine("User ID:\nName: {0}\nLast Name: {1}\nHour Wage: {2}",fName,lName,hWage);
        }

        public void PrintSSN()
        {
            Console.WriteLine("Social Security number: {0}",SSN);
        }

        


    }
}
