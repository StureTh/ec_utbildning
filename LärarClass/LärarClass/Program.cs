using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LärarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();
            Lärare bossen = new Lärare();
            Student elev1=new Student("Nils","Johansson",25,"Lyckliga Gatan","StrandÄngsSKolan");
            bossen.AddStudent(elev1);
            bossen.PrintStudent();
            Console.ReadLine();
        }
    }
}
