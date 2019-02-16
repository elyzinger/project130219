using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = y;
            this.y = y;
        }
        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if (x >= 0 && x <= MyCanvas.maxWidth)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("illegal value");
            }

        }
        internal void SetY(int y)
        {
            if (y >= 0 && y <= MyCanvas.maxWidth)
            {
                this.y = y;
            }
            else
            {
                Console.WriteLine("illegal value");
            }

        }
        public override string ToString()
        {
            return $"point: ({this.x},{this.y})";
        }

    }
}
