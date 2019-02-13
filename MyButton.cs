using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasProject
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point BottomRight;
        private int width;
        private int height;
        internal MyButton(Point topLeft, Point BottomRight)
        {
            this.topLeft = topLeft;
            this.BottomRight = BottomRight;
        }
        internal int GetWidth()
        {
            return this.width = BottomRight.GetX() - topLeft.GetX();
        }
        internal int GetHeight()
        {
            return this.height = topLeft.GetY() - BottomRight.GetY();
        }
        internal bool SetTopleft(Point topleft)
        {
            return topleft.GetX() < BottomRight.GetX() && topleft.GetY() > BottomRight.GetY();
        }
        internal bool SetBottomRight(Point buttomright)
        {
            return topLeft.GetX() < BottomRight.GetX() && topLeft.GetY() > BottomRight.GetY();
        }
        internal Point GetTopLeft()
        {
            return topLeft;
        }
        internal Point GetBottomRight()
        {
            return BottomRight;
        }

        public override string ToString()
        {
            return $"width: {width}, height: {height} top left button: {topLeft} buttom right button: {BottomRight}";
        }
    }
}
