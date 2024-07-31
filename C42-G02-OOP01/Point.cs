using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP01
{
    internal struct Point
    {
        public double X { set; get; }
        public double Y { set; get; }

        public Point(double _X,double _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
}
