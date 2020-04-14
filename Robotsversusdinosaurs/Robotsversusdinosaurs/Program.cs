using System;

namespace Robotsversusdinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();

            battlefield.battleRounds();
         
        }
        
    }
}
//there is a battlefield 
//fleets containing robots and herds containing dinosaurs in the battlefield 
//robots and dinosaurs attack each other
//power levels and health decrease unitl death
//when one side dies the other side wins