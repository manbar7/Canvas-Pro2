using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyCanvas
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


        }

    }
}
