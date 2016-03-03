using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LärarClass
{
    class Person
    {
        public string Name { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        public Person(string name="",string lName="",int age=0,string adress="")
        {
            this.Name = name;
            this.LName = lName;
            this.Age = age;
            this.Adress = adress;


        }

        public void PrintInfo()
        {
            Console.WriteLine("Current user info is: {0},{1},{2},{3}", Name,LName,Age,Adress);
        }
    }
}
