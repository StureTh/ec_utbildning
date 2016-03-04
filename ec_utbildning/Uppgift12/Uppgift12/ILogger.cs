using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    interface ILogger
    {
      List<string> LogList { get; set; }
        void Log(string message);

        void PrintList();
    }
}
