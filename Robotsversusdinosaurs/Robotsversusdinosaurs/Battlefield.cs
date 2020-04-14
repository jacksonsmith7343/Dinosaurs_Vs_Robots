using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Battlefield
    {

        //member variables (Has A)
        public Fleet fleet;
        public Herd herd;




        //constructor (Spawner)

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();

        }



        //member methods (Can do)

        public void battleRounds()
        
        {

           fleet.robotsList[robotsDeafeated].attackOpponet(herd.dinosaursList[dinosaursDefeated]);
        herd.dinosaursList[dinosaursDefeated].attackOpponent(fleet.robotsList[robotsDefeated]);


    }









    //while 
    //( robotsList or dinosaurList is > 0


    //else
    //end game

}
}
