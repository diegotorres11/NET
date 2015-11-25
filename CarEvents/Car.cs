using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarEvents
{
    class Car
    {
        public delegate void CarEngineHandler(string msg);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        private bool carIsDead = false;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                if (MaxSpeed - CurrentSpeed == 10 && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
