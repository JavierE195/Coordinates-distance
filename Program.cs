﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert x coordinate: ");
            double xPoint = double.Parse(Console.ReadLine());

            Console.Write("Please insert y coordinate: ");
            double yPoint = double.Parse(Console.ReadLine());

            Point point01 = new Point ();
            point01.Distance();

            Point point02 = new Point();
            point02.xCoordinate = xPoint;
            point02.yCoordinate = yPoint;
            point02.Distance();

            Console.ReadKey();

        }
    }
}
