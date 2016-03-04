using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning10
{
    class MotorCycle:Vehicle
    {
        public MotorCycle():base("MotorCycle")
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
