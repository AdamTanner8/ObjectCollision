using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    class BasicObject : BaseObject
    {

        private CollisionCircle collCircle;

        public BasicObject(Point l, Vector v, Vector a, Stage s) : base(l, v, a, s) 
        {
            collCircle = new CollisionCircle(l, 5);
        }

        public override void move()
        {
            addVelocity(acceleration);
            collisionCheck();
            location = new Point((int)(velocity.Scalar * velocity.Direction.X + location.X), (int)(velocity.Scalar * velocity.Direction.Y + location.Y));
        }

        public override void collisionCheck()
        {
            for(int i = 0; i < stage.getObjectNumber(); i ++)
            {

                BaseObject obj = stage.getObject(i);

                if (obj.Location != location)
                {

                    Point? collPoint = obj.getCollisionArea().Collide(collCircle);

                    if(collPoint != null)
                    {
                        // Inelastic collision

                        Vector tempVelocity = Velocity;
                        Velocity = new Vector(obj.Velocity);
                        obj.Velocity = new Vector(tempVelocity);

                        Vector tempAcceleration = Acceleration;
                        Acceleration = new Vector(obj.Acceleration);
                        obj.Acceleration = new Vector(tempAcceleration);

                    }
                }
            }
        }

        public override CollisionArea getCollisionArea()
        {
            return collCircle;
        }
    }
}
