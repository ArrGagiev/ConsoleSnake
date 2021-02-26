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

        public void DrowLine() //Метод вызывающий у точек свойство рисоваться в консоль
        {
            foreach (Point p in points) //ДОСТАЮ каждую точку из списка(points) и вызываю
            {
                p.Drow(); // ...у неё cвойство рисоваться в консоль
            }
        }
    }
}
