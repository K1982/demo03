﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new vehicle
            Vehicle car = new Vehicle();
            car.Name = "Kaara";
            car.Speed = 80;
            car.Tyres = 4;
            car.PrintData();
            car.ToString();

            Vehicle motorbike = new Vehicle();
            motorbike.Name = "Harrikka";
            motorbike.Speed = 150;
            motorbike.Tyres = 2;
            motorbike.PrintData();
            motorbike.ToString();



            Console.ReadLine();
        }
    }
}
