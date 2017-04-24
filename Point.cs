using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Point
    {
        public double xCoordinate;
        public double yCoordinate;
        public static int count;

        public  Point ()
        {
            xCoordinate = 0;
            yCoordinate = 0;
            count++;

        }

        public Point(double _xCoordinate, double _yCoordinate)
        {
            xCoordinate = _xCoordinate;
            yCoordinate = _yCoordinate;
            count++;
        }

        public void Distance()
        {
            double distance = Math.Sqrt((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate));
            Console.WriteLine("\nThe distance from point (0, 0) to point (" + xCoordinate + ", " + yCoordinate +") is: " + distance + " units.");
        }
    }
}
