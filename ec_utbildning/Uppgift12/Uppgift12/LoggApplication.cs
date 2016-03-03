using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    class LoggApplication
    {
        private ILogger _logger;
     
    
       
        public LoggApplication(ILogger logger)
        {
            this._logger = logger;
        }

        public void Run()
        {
            while (true)
            {


                Console.WriteLine("1) Add message to log\n2)Print log\n3)Quit application");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        _logger.Log(Console.ReadLine());
                        break;
                    case 2:
                        _logger.PrintList();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
