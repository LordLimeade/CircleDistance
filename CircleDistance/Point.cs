using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDistance
{
    class Point : IComparable
    {
        /**
         * Arguments
         *  X: X-Coordinate
         *  Y: Y-Coordinate
         * 
         */
        private double _x, _y;

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public Point(double x, double y)
        {
            setX(x);
            setY(y);
        }

        public void setX(double x)
        {
            _x = x;
        }

        public void setY(double y)
        {
            _y = y;
        }

        public double getX()
        {
            return _x;
        }

        public double getY()
        {
            return _y;
        }

        public double getDistance()
        {
            return (Math.Sqrt(Math.Pow((_x - 0), 2) + Math.Pow((_y - 0), 2)));
        }

        public int CompareTo(object obj)
        {
            Point hold = (Point)obj;
            return this.getDistance().CompareTo(hold.getDistance());
        }
    }
}
