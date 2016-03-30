using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning11
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

        public string EngineStatus()
        {
            return (EngineIsRunning) ? "The engine is running WROOOOOOOOOOM" : "The engine is not running BUUUUUUUUU";
        }

        public override string DescribeVehicle()
        {
            return base.DescribeVehicle()+EngineStatus();
        }

    }
}
