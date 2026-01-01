using Jet_Fighter.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Jet_Fighter.Logic
{
    public class Jet : Vehicle
    {
        /// <summary>
        /// Indicates whether the afterburner is currently engaged.
        /// Indicates whether the landing gear is currently deployed.
        /// Indicates whether the afterburner is available for use.
        /// </summary>
        public bool afterburnerEngaged;
        public bool landingGearDeployed;
        public bool afterburnerAvailable;

        /// <summary>
        /// Initializes a new instance of the Jet class with default property values.
        /// so I set some default values for speed, health, acceleration, fuel capacity, and maximum altitude.
        /// it is only for a basic representation of a selectable jet fighter.
        /// </summary>
        public Jet()
        {
            this.speed = 400;
            this.health = 120;
            this.acceleration = 50;
            this.fuelCapacity = 2000;
            this.max_alt = 32000;
        }

        public void afterburner_avail()
        {
            afterburnerAvailable = true; // Set the afterburner as available by default as it is not implemented yet. i will change the logic later.
        }

        /// <summary>
        /// Toggles the landing gear state between deployed and retracted, adjusting speed and acceleration accordingly.
        /// </summary>
        /// <remarks>When the landing gear is deployed, the speed and acceleration are reduced to simulate
        /// the effects of extended gear. Retracting the landing gear restores speed. This method should be called to
        /// change the landing gear state during flight operations.</remarks>
        public void gear_out()
        {
            // I've changed the logic here to toggle the landing gear state as a bool that flips between true and false like a flag.
            landingGearDeployed = !landingGearDeployed;

            if (landingGearDeployed)
            {
                this.speed -= 50; // Reduce speed when landing gear is deployed
                this.acceleration -= 10; // Reduce acceleration when landing gear is deployed
            }
            else
            {
                this.speed += 50; // Increase speed when landing gear is retracted
                this.acceleration += 10; // restore acceleration when landing gear is retracted
            }
        }

        /// <summary>
        /// Engages or disengages the afterburner, increasing acceleration if the afterburner is available.
        /// </summary>
        /// <remarks>Calling this method toggles the afterburner state. When engaged and available,
        /// acceleration is increased. If the afterburner is already engaged, calling this method will disengage it and
        /// no additional acceleration will be applied.</remarks>
        public void afterburner_on()
        {
            afterburnerEngaged = !afterburnerEngaged;

            if (afterburnerEngaged && afterburnerAvailable)
            {
                this.acceleration += 20; // Increase acceleration when afterburner is engaged
            }
            else if (!afterburnerEngaged)
            {
                this.acceleration -= 20; // Decrease acceleration when afterburner is disengaged
            }
        }
    }
}
