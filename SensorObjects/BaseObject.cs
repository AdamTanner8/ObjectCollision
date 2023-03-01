using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    abstract class BaseObject
    {
        protected Point location;
        protected Vector velocity;
        protected Vector acceleration;
        protected Stage stage;

        public Vector Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }
        public Point Location
        {
            get { return location; }
            set
            {
                if (value.X >= 0 && value.Y >= 0)
                    location = value;
                else
                    throw new ArgumentException("Location parameters can't be negative!");
            }
        }
        public Vector Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Stage Stage
        {
            get { return stage; }
        }


        protected BaseObject(Point l, Vector v, Vector a, Stage s)
        {
            location = l;
            velocity = v;
            acceleration = a;
            stage = s;
        }

        protected void addAcceleration(Vector a)
        {
            double newAcceleration = acceleration.Scalar + a.Scalar - stage.Friction;
            if (newAcceleration >= 0.0)
                acceleration.Scalar = newAcceleration;
            else
                acceleration.Scalar = 0.0;

            acceleration.Direction = new Point(acceleration.Direction.X + a.Direction.X, acceleration.Direction.Y + a.Direction.Y);
        }

        protected void addVelocity(Vector v)
        {
            velocity.Scalar += v.Scalar;
            velocity.Direction = new Point(velocity.Direction.X + v.Direction.X, velocity.Direction.Y + v.Direction.Y);
        }


        public abstract void move();

        public abstract void collisionCheck();

        public abstract CollisionArea getCollisionArea();

    }
}
