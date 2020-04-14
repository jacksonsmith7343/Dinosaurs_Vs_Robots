using System;
using System.Collections.Generic;
using System.Text;

namespace Robotsversusdinosaurs
{
    class Herd
    {
        //member variables (Has A)
        public List<Dinosaur> dinosaursList;


        //constructor (Spawner)

        public Herd()
        {
            dinosaursList = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("Velociraptor");
            Dinosaur dinosaur2 = new Dinosaur("TRex");
            Dinosaur dinosaur3 = new Dinosaur("Spinosaurus");

            dinosaursList.Add(dinosaur1);
            dinosaursList.Add(dinosaur2);
            dinosaursList.Add(dinosaur3);

        }

        //member methods (Can do)



        //dinosaur objects are stored here in the herd class
    }
}
