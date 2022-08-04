using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle Drive Abstract");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Drive Virtual");
        }
    }
}
