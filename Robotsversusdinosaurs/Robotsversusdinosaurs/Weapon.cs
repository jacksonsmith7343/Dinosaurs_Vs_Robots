using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Weapon
    {
        //member variables (Has A)
        public string type;
        public int attackPower;


        //Constructor (Spawner)
        public Weapon(string type)
        {
            this.type = type;

            Random rng = new Random();

            attackPower = rng.Next(10, 100);
            
        }

        //member methods (Can do)

    }
}
