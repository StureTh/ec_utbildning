using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning10
{
    class Car:Vehicle
    {
        public Car():base("Car")
        {
            
        }
        public void StartEngine()
        {
            EngineIsRunning = true;
        }

        public void StopEngine()
        {
            EngineIsRunning = false;
        }
    }
}
