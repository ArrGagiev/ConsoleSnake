using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    // Создание модели линии - Багаж -
    class Figura
    {
        //Линия это набор экземплярОВ сущности точек - Список
        protected List<Point> points; // ОБЪЯВЛЕНИЕ списка - Создание -

        public void DrawLine() //Метод вызывающий у точек свойство рисоваться в консоль
        {
            foreach (Point p in points) //ДОСТАЮ каждую точку из списка(points) и вызываю
            {
                p.Draw(); // ...у неё cвойство рисоваться в консоль
            }
        }

        internal bool IsHit(Figura figura)
        {
            foreach (var p in points)
            {
                if (figura.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in points)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
