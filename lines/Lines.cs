using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lines
{
    class Lines
    {
       

        public Lines(int x0, int y0, int x1, int y1)
        {
            _p0 = new Point(x0, y0);
            _p1 = new Point(x1, y1);
        }
        public Lines(Point p0, Point p1)
        {
            _p0 = p0;
            _p1 = p1;
        }

        public Lines GetCopy()
        {
            Lines line = (Lines)MemberwiseClone();
            line._p0 = _p0.GetCopy();
            line._p1 = _p1.GetCopy();
            return line;
        }
        
        public override string ToString()
        {
            return string.Format("Первая точка: {0}, Вторая точка: {1}, Длина отрезка между этими точками {2}", _p0, _p1, this.Length() );
        }
        public int P0X
        {
            get
            {
                return _p0.X;
            }
                       
        }
        public int P0Y
        {
            get
            {
                return _p0.Y;
            }

        }
        public int P1X
        {
            get
            {
                return _p1.X;
            }

        }
        public int P1Y
        {
            get
            {
                return _p1.Y;
            }

        }
       
        public double Length()
        {
            double Length = System.Math.Sqrt(System.Math.Pow(_p0.X - _p1.X, 2) + System.Math.Pow(_p0.Y - _p1.Y, 2));
            return Length;
        }
        public Point this[double t]
        {
            get
            {
                Point p = new Point();
                double ax = 0;
                double ay = 0;
                ax = (P1X - P0X) / Length();
                ay = (P1Y - P0Y) / Length();
                p.X = (int)(P0X + ax * t);
                p.Y = (int)(P0Y + ay * t);
                return p;

            }

        }
        private Point _p0 = null;
        private Point _p1 = null;

    }
}
