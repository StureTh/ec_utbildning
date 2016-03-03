using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LärarClass
{
    class Student:Person
    {
        public string Skola { get; set; }

        public Student(string name="",string lName="",int age=0,string adress="",string skola=""):base(name,lName,age,adress)
        {
            this.Skola = skola;
        }
    }
}
