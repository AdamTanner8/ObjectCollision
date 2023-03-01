using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    class Vector
    {
        private double scalar;
        private Point direction;

        public double Scalar
        {
            get { return scalar; }
            set {
                if (value >= 0)
                    scalar = value;
                else
                    throw new ArgumentException("Vwctor scalar can't be negative!");
            }
        }

        public Point Direction
        {
            get { return direction; }
            set { direction = normalizeVector(value); }
        }

        public Vector(double s, Point d)
        {
            scalar = s;
            direction = d;
        }

        public Vector(Vector v)
        {
            scalar = v.scalar;
            direction = new Point(v.direction.X, v.direction.Y);
        }

        public static Point normalizeVector(Point v)
        {
            int totalLength = v.X + v.Y;
            return new Point(v.X / totalLength, v.Y / totalLength);
        }

        public static Point getDirectionVector(Point p1, Point p2)
        {
            int coordX = p2.X - p1.X;
            int coordY = p2.Y - p1.Y;
            return normalizeVector(new Point(coordX, coordY));
        }

        /*public static Point negateDirection(Point d)
        {
            return normalizeVector(new Point(-d.X, -d.Y));
        }*/
    }
}
