using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorObjects
{
    internal class Stage
    {
        private List<BaseObject> objects;
        private double friction;

        public double Friction
        {
            get { return friction; }
            set 
            {
                if (value >= 0)
                    friction = value;
                else
                    throw new ArgumentException("Friction can't be negative value!");
            }
        }

        public Stage()
        {
            objects = new List<BaseObject>();
            objects.Add(new BasicObject(new Point(0, 0), new Vector(0.0, new Point(0,0)), new Vector(0.0, new Point(0, 0)), this));
        }

        public BaseObject getObject(int i)
        {
            return objects[i];
        }

        public int getObjectNumber()
        {
            return objects.Count;
        }
    }
}
