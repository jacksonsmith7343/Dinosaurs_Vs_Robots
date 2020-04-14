using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Fleet
    {

        //member variables (Has A)
        public List<Robot> robotsList;

        //constructor (Spawner)
        public Fleet()
        {
            robotsList = new List<Robot>();
            Robot robot1 = new Robot("Maximus", "Raygun");
            Robot robot2 = new Robot("Terminus", "Shoulderblaster");
            Robot robot3 = new Robot("Flexor", "Ironfists");

            robotsList.Add(robot1);
            robotsList.Add(robot2);
            robotsList.Add(robot3);

        }
        

        //member methods (Can do)

        //robot objects are stored in the fleet

    }
}
