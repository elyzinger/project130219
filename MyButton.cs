using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;
        public MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }
        internal int GetWidth()
        {
            return this.width;
        }
        internal int GetHeight()
        {
            return this.height;
        }
        private void UpdateWidthAndHeight()
        {
            this.width = bottomRight.GetX() - topLeft.GetX();
            this.height = bottomRight.GetY() - topLeft.GetY();
        }
        internal bool SetTopLeft(Point pointtopleft)
        {
            if (pointtopleft.GetX() < bottomRight.GetX() && pointtopleft.GetY() < bottomRight.GetY())
            {
                this.topLeft = pointtopleft;
                this.UpdateWidthAndHeight();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool SetBottomRight(Point pointbottomright)
        {
            if (topLeft.GetX() < bottomRight.GetX() && =topLeft.GetY() < bottomRight.GetY())
            {
                this.bottomRight = pointbottomright;
                this.UpdateWidthAndHeight();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal Point GetTopLeft()
        {
            return this.topLeft;
        }
        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }
        public override string ToString()
        {
            return $"button topleft: {this.topLeft}, bottom right: {this.bottomRight}, width: {this.width}, height: {this.height}";
        }
    }
        
}
