using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
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


        public Employee(int sSN,string fName,string lName,int hWage)
        {
            this.sSN = sSN;
            this.fName = fName;
            this.lName = lName;
            this.hWage = hWage;


        }

        public Employee(int sSN=0)
        {
            this.sSN = sSN;
        }

        public void GetPersonReadOut()
        {
            // $ tecknet gör att vi kan sätta variabel namnen direkt i stringen
            Console.WriteLine($"User ID:\nName: {fName}\nLast Name: {lName}\nHour Wage: {hWage}");
        }

        public void GetSSNReadOut() // Skriver ut SSN
        {
            Console.WriteLine($"Social Security number: {SSN}");
        }

        


    }
}
