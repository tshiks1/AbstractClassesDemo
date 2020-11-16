using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public override string DriveAbstract()
        {
            return "Runs smoothly";
        }
        public bool HasSideCart()
        {
            return true;
        }
        public bool NumberOsWheels()
        {
            return true;
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
