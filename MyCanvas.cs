using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    class MyCanvas
    {
        public const int maxwidth = 800;
        public const int maxheight = 600;
        private static int buttonindex = 0;
        private static MyButton[] buttons = new MyButton[maxbuttons];
        private static int maxbuttons = 3;

        public static bool CreateNewButton(int x1, int x2,int y1, int y2)
        {
            bool result = false;
            Point topleft = new Point(x1, x2);
            Point bottomright = new Point(x2, y2);
            if (buttonindex < maxbuttons && topleft.GetX()<maxwidth && topleft.GetY()<maxheight && bottomright.GetX()<maxwidth && bottomright.GetY() < maxheight)
            {
                buttons[buttonindex] = new MyButton(topleft, bottomright);
                buttonindex++;
                result = true;
            }
            return result;
        }
        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            bool result;
            if(buttonNumber <= 0 || buttonNumber > buttonindex)
            {
                result = false;
            }
            else
            {
                int newTopLeftX = buttons[buttonNumber].GetTopLeft().GetX() + x;
                int newTopLeftY = buttons[buttonNumber].GetTopLeft().GetY() + y;
                int newBottomRightX = buttons[buttonNumber].GetTopLeft().GetX() + x;
                int newBottomRightY = buttons[buttonNumber].GetTopLeft().GetY() + y;
                Point newTopLeft = new Point(newTopLeftX, newTopLeftY);
                Point newBottomRight = new Point(newBottomRightX, newBottomRightY);
                buttons[buttonNumber] = new MyButton(newTopLeft, newBottomRight);
                result = true;
            }
            return result;
        }
    }
}
