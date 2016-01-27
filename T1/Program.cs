using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add new heater
            Heater heater = new Heater();
            heater.PrintData();
            heater.Temperature=50;
            heater.Humidity = 20;
            heater.IsOn = true;
            heater.PrintData();
            Console.WriteLine(heater.ToString());

            Console.WriteLine("Temperature = " + heater.Temperature);

            

            Console.ReadLine();
        }
    }
}
