﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning10
{
    class Vehicle
    {
        public bool EngineIsRunning { get; set; }
        public string Type { get; set; }
        public Vehicle(string type,bool engineIsRunning=false)
        {
            this.Type = type;
            this.EngineIsRunning = engineIsRunning;
        }

        public string DescribeVehicle()
        {
            return $"This Vehicle is a {Type}";
        }

        

    }
}
