using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Dinosaur
    {
        //member variables (Has A)
        public string typeOfDinosaur;
        public int health;
        public int energyLevel;
        public int attackPower;


        //constructor (Spawner)

        public Dinosaur(string typeOfDinosaur)
        {
            this.typeOfDinosaur = typeOfDinosaur;
            health = 100;
            energyLevel = 100;
            Random rng = new Random();

            attackPower = rng.Next(10, 100);

        }

        //member methods (Can do)
        //attack a robot
        //lose health

        public void takeHit()
            //lose health points based on how much attack power is given 
        {
        

        }
        public void energy()
            //lose energy when the dinosaur attacks
        {

        }

        public void attackOpponent(Robot robot)
  
        {
            robot.health -= attackPower;
        }


    }
}
