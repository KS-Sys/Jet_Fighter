using System.Numerics;

namespace Jet_Fighter.Logic
{
    public class Vehicle
    {
        protected float speed;
        protected int health;
        protected float acceleration;
        protected float fuelCapacity;
        protected float max_alt;

        public Vector2 position;
        public float rotation;

        public Vehicle()
        {
            this.speed = 0;
            this.health = 0;
            this.acceleration = 0;
            this.fuelCapacity = 0;
            this.max_alt = 0;
        }
    }
}
