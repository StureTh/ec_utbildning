using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    class Logger:ILogger
    {
        public List<string> LogList { get; set; }

        public Logger()
        {
            LogList=new List<string>();
        }

        public void Log(string message)
        {
            LogList.Add(message);
        }

        public void PrintList()
        {
            foreach (var item in LogList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
