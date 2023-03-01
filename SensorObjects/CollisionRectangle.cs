using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    class CollisionRectangle : CollisionArea
    {

        private int width;
        private int height;

        public double rotation;

        public int Width
        {
            get { return width; }
            set 
            {
                if (value > 0)
                    width = value;
                else
                    throw new ArgumentException("Collision rectangle width must be bigger than 0!");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Collision rectangle height must be bigger than 0!");
            }
        }

        public CollisionRectangle(Point c, int w, int h) : base(c)
        {
            width = w;
            height = h;
        }

        public override Point? Collide(CollisionCircle collCircle)
        {
            return new Point(0, 0);
        }

        public override Point? Collide(CollisionRectangle collRectangle)
        {
            return new Point(0, 0);
        }


        /* Checks whether the two rectangle objects have edges that intersect at the specific moment; however it uses the equation of a straight line so further calculations needed (constraintCheck method)
         * 
         * centerJoinVector: the vector pointing from the center of object1 to the center of object2
         * centerJoinVectorAngle: the angle of centerJoinVector relative to (0,1) vector in the Cartesian coordinate system (degrees increase clockwise)
         */
        public Point? hitRectangleEdge(double centerJoinVectorAngle, Point centerJoinVector)
        {

            double rectCrossAngle = Math.Atan((double)Width / (double)Height); // rotation of the object relative to the same direction as centerJoinVectorAngle
            Point point;
            Vector direction;

            // TODO: What if centerJoinVectorAngle == rectCrossAngle and what if Sin(centerJoinVectorAngle) == 0 or Cos(centerJoinVectorAngle) == 0 ?


            if (Math.Abs(Math.Sin(centerJoinVectorAngle)) > Math.Abs(Math.Sin(rectCrossAngle)))
            {

                if (Math.Sin(centerJoinVectorAngle) > 0)
                {
                    point = new Point(center.X-(int)(Width/2*Math.Cos(rotation))-(int)(Height/2*Math.Sin(rotation)), center.Y - (int)(Width / 2 * Math.Sin(rotation)) - (int)(Height / 2 * Math.Cos(rotation)));
                    direction = new Vector(Height, Vector.normalizeVector(new Point((int)(Height * Math.Cos(rotation)), (int)(Height * Math.Sin(rotation)))));
                    return new Point();
                }  
                else
                {
                    point = new Point(center.X + (int)(Width / 2 * Math.Cos(rotation)) + (int)(Height / 2 * Math.Sin(rotation)), center.Y - (int)(Width / 2 * Math.Sin(rotation)) - (int)(Height / 2 * Math.Cos(rotation)));
                    direction = new Vector(Height, Vector.normalizeVector(new Point((int)(Height * Math.Cos(rotation)), (int)(Height * Math.Sin(rotation)))));
                }

            }
            else
            {

                if (Math.Cos(centerJoinVectorAngle) > 0)
                {
                    point = new Point(center.X + (int)(Width / 2 * Math.Cos(rotation)) + (int)(Height / 2 * Math.Sin(rotation)), center.Y - (int)(Width / 2 * Math.Sin(rotation)) - (int)(Height / 2 * Math.Cos(rotation)));
                    direction = new Vector(Width, Vector.normalizeVector(new Point((int)(Width * Math.Cos(rotation)), (int)(Width * Math.Sin(rotation)))));
                }
                else
                {
                    point = new Point(center.X - (int)(Width / 2 * Math.Cos(rotation)) - (int)(Height / 2 * Math.Sin(rotation)), center.Y + (int)(Width / 2 * Math.Sin(rotation)) + (int)(Height / 2 * Math.Cos(rotation)));
                    direction = new Vector(Width, Vector.normalizeVector(new Point((int)(Width * Math.Cos(rotation)), (int)(Width * Math.Sin(rotation)))));
                }
            }

            double param2 = (point.Y - center.Y + (direction.Direction.Y / direction.Direction.X) * (center.X - point.X)) / (centerJoinVector.Y - centerJoinVector.X / direction.Direction.X);
            double param1 = ((center.X - point.X) + param2 * centerJoinVector.X) / direction.Direction.X;


            Point collPoint = new Point((int)(center.X + param2 * centerJoinVector.X), (int)(center.Y + param2 * centerJoinVector.Y));
            if (constraintCheck(collPoint, point, direction))
                return collPoint;
            else
                return null;
        }

        // Needs to be checked if the calculated intersection of the two rectangle objects are truly part of both edge
        private bool constraintCheck(Point collPoint, Point point, Vector direction)
        {
            double directionLength = Math.Sqrt(Math.Pow(direction.Direction.X, 2) + Math.Pow(direction.Direction.Y, 2));
            if ((collPoint.X >= point.X && collPoint.Y >= point.Y) 
                && (collPoint.X <= point.X + (int)(Height * direction.Direction.X / directionLength) && collPoint.Y <= point.Y + (int)(Height * direction.Direction.Y / directionLength)))
                    return true;
            return false;
        }
    }
}
