using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Robot
    {
        //member variables (Has A)
        public string nameOfRobot;
        public int health;
        public int powerLevel;
        public Weapon weapon;





        //constructor (Spawner)
        public Robot(string nameOfRobot, string weaponType)
        {
            this.nameOfRobot = nameOfRobot;
            health = 100;
            powerLevel = 100;
            weapon = new Weapon (weaponType);
        }
      



        //member methods (Can do)
        //attack a dinosaur
        //lose health when attacked by a robot
        //lose energy when making an attack

        public void attackOpponet(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;

        }
        

    }
}
