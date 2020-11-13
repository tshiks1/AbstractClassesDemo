using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public override string DriveAbstract()
        {
           return  "Easy to drive";
        }
        public bool HasTrunk()
        {
            return true;
        }
    }
}
