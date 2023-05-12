using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "Green";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 10;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myLizard = new Reptile();
            myLizard.HasTail = true;
            myLizard.IsGreen = true;
            myLizard.HasLegs = true;
            myLizard.WhatCity = "San Francisco";

            var myAnimals = new Animal[] { myBird, myLizard };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old!");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"Alive:{animal.IsAlive}");
            }
        }
    }
}
