using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static public class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHeight = 600;
        private static int ButtonIndex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (ButtonIndex == MaxButtons)
            {
                return false;
            }


            if (x1 <= MaxWidth && y1 <= MaxHeight && x2 <= MaxWidth && y2 <= MaxHeight)
            {
                Point p1 = new Point(x1, y2);
                Point p2 = new Point(x2, y2);
                MyButton Btn1 = new MyButton(p1, p2);

                ButtonIndex++;
                return true;
            }
            return false;
        }
         public static bool DeleteLastButton()
        {
            if (buttons[ButtonIndex-1] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
      public static void ClearAllButton()
        {
            if (ButtonIndex > 0)
            {
                buttons = new MyButton[MaxButtons];
                ButtonIndex = 0;
            }
        }
        public static int GetCurrentNumbersOfButtons()
        {
            return ButtonIndex;
        }
        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }
        public static int GetTheMaxWidthOfAButton()
        {
            int maxWidth = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].GetWidth() > maxWidth)
                {
                    maxWidth = buttons[i].GetWidth();
                }
            }
            return maxWidth;
        }
        public static int GetTheMaxHeightOfAButton()
        {
            int MaxHeight = 0;
            for (int i=0;i<buttons.Length;i++)
            {
                if (buttons[i].GetHeight() > MaxWidth)
                {
                    MaxHeight = buttons[i].GetHeight();
                }
            }
            return MaxHeight;

        }
        public static void Print()
        {
            for (int i = 0;i < buttons.Length; i++)
            {
                Console.Write("Top left x: " + buttons[i].GetTopLeft().GetX());
                Console.WriteLine("Top left y: " + buttons[i].GetTopLeft().GetY());
                Console.Write("Bottom right x: " + buttons[i].GetBottomRight().GetX());
                Console.WriteLine("bottom right y: " + buttons[i].GetBottomRight().GetY());
            }
        }
        public static bool IsPointInsideAButton(int x,int y)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (x < buttons[i].GetTopLeft().GetX() || x > buttons[i].GetBottomRight().GetX() || y > buttons[i].GetTopLeft().GetY() || y < buttons[i].GetBottomRight().GetY())
                {
                    return true;
                }

            }
            return false;
        }
         
        
        


        

    }
}
