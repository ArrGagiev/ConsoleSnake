using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    // Создание модели линии - еще мне нравится такое выражение как - Багаж
    class Figura
    {
        //Линия это набор экземпляроВ сущности точек - в данном примере - Список
        protected List<Point> points;

        public void DrawLine() //Метод вызывающий у точек способность появляться в консоли
        {
            foreach (Point p in points) //Достаю каждую точку из списка(points) и вызываю...
            {
                p.Draw();                         // ...у неё cвойство рисоваться в консоль.
            }
        }

        //Благодаря полиморфизму могу создать два одинаковых метода, принимающие разные аргументы
        
        //Проверяем, фигуру которую мы передаем в качестве аргумента...
        internal bool IsHit(Figura figura)
        {
            foreach (var p in points)
            {
                if (figura.IsHit(p))//...пересекается ли она с какой-либо точкой
                {
                    return true;
                }
            }
            return false;
        }

        //Проверяем с какой именно точкой мы пересекаемся
        private bool IsHit(Point point)
        {
            foreach (var p in points)
            {
                if (p.Intersection(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
