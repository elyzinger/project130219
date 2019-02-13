using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasProject
{
    public class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHEight = 600;
        private static int buttonIndex = 0;
        private static MyButton[] buttons= new MyButton[MaxButtons];
        private static int MaxButtons = 3;
        public static bool CreateNewButton(int x1,int x2,int y1,int y2)
        {
            bool result = true;
            Point topleft = new Point(x1, y2);
            Point bottomright = new Point(x2, y2);
            if (buttonIndex != MaxButtons && topleft.GetX() < MaxWidth && bottomright.GetX() < MaxWidth  && topleft.GetY() < MaxHEight  && bottomright.GetY() < MaxHEight)
            {
                buttons[buttonIndex] = new MyButton(topleft, bottomright);
                buttonIndex++;           
                
            }
            else 
            {
                result = false;
            }
            return result;
        }
        public static bool MoveButton(int buttonNumber, int x, int y)
        {
           bool result;
            if (buttonIndex == 0)
            {
                result = false;
            }



            return result;
        }
        public static bool DeleteLastButton()
        {

        }
        public static void ClearAllButtons()
        {

        }
        public static int GetCurrentNumberOfButtons()
        {

        }
        public static int GetMaxNumberOfButtons()
        {

        }
        public static int GetTheMaxWidthOfButtons()
        {

        }
        public static int GetTheMaxHeightOfButtons()
        {

        }
        public static bool IsPointInsideAButton(x, y)
        {

        }
        public static bool CheckIfAnyButtonIsOverlaping()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
