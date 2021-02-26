using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class VertiLine : Figura
    {
        public VertiLine(int yTop, int yBottom, int x, char sym) //начало - конец - высота - материал: линии 
        {
            points = new List<Point>(); /* - Создаю массив элементов линии 
                                         * - Единично... точка 
                                         * - Создание объекта для Mассива points, класса Figura */

            for (int y = yTop; y <= yBottom; y++) //Сам процесс создания
            {
                Point p = new Point(x, y, sym);
                points.Add(p); //ДОБАВЛЕНИЕ точки и её перенос В МАССИВ класса Figura
            }
        }
    }
}
