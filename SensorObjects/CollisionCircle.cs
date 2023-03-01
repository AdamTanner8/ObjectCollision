using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    class CollisionCircle : CollisionArea
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
        }

        public CollisionCircle(Point c, int r) :base(c)
        {
            radius = r;
        }

        public override Point? Collide(CollisionCircle collCircle)
        {
            double angle = Math.Asin((collCircle.Center.X + center.X) / (collCircle.Radius + Radius));

            if (angle == Math.Acos((collCircle.Center.Y + center.Y) / (collCircle.Radius + Radius)))
                return new Point((int)(center.X + radius * Math.Sin(angle)), (int)(center.X + radius * Math.Cos(angle)));
            else
                return null;
        }

        public override Point? Collide(CollisionRectangle collRectangle)
        {

            Point centerJoinVector = Vector.normalizeVector(new Point(collRectangle.Center.X-center.X, collRectangle.Center.Y - center.Y));
            double centerJoinVectorAngle = Math.Atan((double)centerJoinVector.X / (double)centerJoinVector.Y);

            return collRectangle.hitRectangleEdge(centerJoinVectorAngle, centerJoinVector);    
        }

    }
}
