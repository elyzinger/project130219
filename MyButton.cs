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
            return this.width;
        }
        internal int GetHeight()
        {
            return this.height;
        }
        internal bool SetTopleft(Point newleft)
        {
            return newleft > 
        }
        internal bool SetBottomRight(Point newright)
        {

        }
        internal Point GetTopLeft()
        {

        }
        internal Point GetBottomRight()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
