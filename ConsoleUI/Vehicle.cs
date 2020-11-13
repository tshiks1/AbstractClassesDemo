using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Altima";
        public int Year { get; set; } = 2017;


        public abstract string DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I love new car smell of {Make} {Model}s. ");
        }

       
    }
}
