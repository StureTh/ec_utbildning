using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LärarClass
{
    class Lärare:Person
    {
      public List<Student> studenter=new List<Student>();

        public Lärare(string name="",string lName="",int age=0,string adress="",string skola=""):base(name,lName,age,adress)
        {
            
        }

        public void AddStudent(Student newStudent)
        {
          studenter.Add(newStudent);  
        }

        public void PrintStudent()
        {
            foreach (Student student in studenter)
            {
                student.PrintInfo();
            }
        }   
    }
}
