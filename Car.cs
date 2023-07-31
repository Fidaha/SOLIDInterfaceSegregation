using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDInterfaceSegregation
{
    internal class Car : IDrivable
    {
        public void Drive(long miles)
        {
            Console.WriteLine("I am driven to {0} miles away ...", miles);
        }

    
    }
}
