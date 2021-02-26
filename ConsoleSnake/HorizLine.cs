using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    //Developer:|☶☴☰☵☳☴
    //Горизонтальная стена наследуемая от "Фигура-Линия".
    class HorizLine : Figura
    {
        public HorizLine(int xLeft, int xRight, int y, char sym) //начало - конец - высота - материал: линии 
        {
            points = new List<Point>(); //Создаю точки линии в указанных кординатах

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                points.Add(p);
            }
        }
    }
}
