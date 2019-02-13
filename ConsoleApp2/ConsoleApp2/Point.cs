using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return x;
        }
        internal int GetY()
        {
            return y;
        }
        internal void SetX(int x)
        {
            if (x < 0 || x > MyCanvas.MaxHeight)
            {
                Console.WriteLine("X - Invalid point value");
            }
            else
            {
                this.x = x;
            }
        }
        internal void SetY(int y)
        {
            if (y < 0 || y > MyCanvas.MaxWidth)
            {
                Console.WriteLine("Y - Invalid point value");
            }
            else
            {
                this.y = y;
            }
        }
        public override string ToString()
        {
            return $"x: {x} y: {y}";
        }



    }
}
