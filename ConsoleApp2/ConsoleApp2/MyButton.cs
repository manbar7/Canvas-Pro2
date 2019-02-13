using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyButton 
    {
        protected Point TopLeft;
        protected Point BottomRight;
        private int Width;
        private int Height;

        internal MyButton(Point topLeft, Point bottomRight) 
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
            SetBottomRight(bottomRight);
            SetTopLeft(topLeft);
        }
        internal int GetWidth()
        {
            return Width;
        }
        internal int GetHeight()
        {
            return Height;
        }
        internal bool SetTopLeft(Point TopLeft)
        {
            if (TopLeft.GetX() < this.BottomRight.GetX() && TopLeft.GetY() > this.BottomRight.GetY())
            {
                this.Height = TopLeft.GetY() - BottomRight.GetY();
                this.Width = BottomRight.GetX() - TopLeft.GetX();
                return true;
            }
            return false;
        }
        internal bool SetBottomRight(Point BottomRight)
        {
            if (BottomRight.GetX() > this.TopLeft.GetX() && BottomRight.GetY() < this.TopLeft.GetY())
            {
                this.Height = TopLeft.GetY() - BottomRight.GetY();
                this.Width = BottomRight.GetY() - TopLeft.GetX();
                return true;
            }
            return false;
        }
        internal Point GetTopLeft()
        {
            return TopLeft;
        }
        internal Point GetBottomRight()
        {
            return BottomRight;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
