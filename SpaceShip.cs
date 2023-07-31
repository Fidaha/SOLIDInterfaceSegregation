using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDInterfaceSegregation
{
    internal class SpaceShip : ILaunchable
    {
        private bool _isRocketLaunched;

        public void Drive(long miles)
        {
            if (!_isRocketLaunched)
            {
                Console.WriteLine("Spaceship can't leave Earth if its rocket is not launched !");
            }
            else
            {
                Console.WriteLine("The spaceship is going {0} miles away", miles);
            }
        }

        public void LaunchRocket()
        {
            _isRocketLaunched = true;
        }
    
    }
}
