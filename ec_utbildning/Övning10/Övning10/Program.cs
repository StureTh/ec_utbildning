﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicleInfo = new VehicleData();
            Car newCar = new Car();
            MotorCycle motorBike = new MotorCycle();
            vehicleInfo.PrintVehicle(newCar);
            vehicleInfo.PrintVehicle(motorBike);
            Console.ReadLine();
        }
    }
}
