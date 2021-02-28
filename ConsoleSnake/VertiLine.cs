using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class VertiLine : Figura
    {
        public VertiLine(int yTop, int yBottom, int x, char sym)
        {
            points = new List<Point>(); 

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                points.Add(p);
            }
        }
    }
}
