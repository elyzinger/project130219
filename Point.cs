using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasProject
{
    internal class Point
    {
        private int x;
        private int y;

        internal Point(int x, int y)
        {
            this.x = x;
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
        internal void  SetX(int newx)
        {
            if(newx > 0 && newx < MyCanvas.MaxWidth && newx < MyCanvas.MaxHEight)
            {
                this.x = newx;
            }
            else
            {
                Console.WriteLine($"x {newx} outside borders");
            }
        }
        internal void SetY(int newy)
        {
            if (newy > 0 && newy < MyCanvas.MaxWidth && newy < MyCanvas.MaxHEight)
            {
                this.y = newy;
            }
            else
            {
                Console.WriteLine($"y {newy} outside borders");
            }
        }
        public override string ToString()
        {
            return $"x: {x} y: {y}"
        }
    }
    
}
