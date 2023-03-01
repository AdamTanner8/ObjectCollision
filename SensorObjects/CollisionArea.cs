using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    // Base object for the collision areas
    abstract class CollisionArea
    {
        protected Point center;

        public Point Center
        {
            get { return center; }
        }

        protected CollisionArea(Point c)
        {
            center = c;
        }

        public abstract Point? Collide(CollisionCircle collCircle);

        public abstract Point? Collide(CollisionRectangle collRectangle);
    }
}
