using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("FirstPost");
            myLogger.Log("second post");
            myLogger.PrintList();
            Console.ReadKey();
        }
    }
}
