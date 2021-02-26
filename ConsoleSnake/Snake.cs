using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Snake : Figura //................  Потому что не нужно забывать, что змея, это тоже по сути всего лишь линия.
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {                                                         /* - Хвост ➝ Начало
                                                                   * - Длина тела
                                                                   * - Направление (Записывается словами, но несут 
                                                                   *   в себе числовые значения - перечисления(enum) */
            direction = _direction;
            points = new List<Point>(); //объявление уже созданного в классе Figura списка
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail); //Принимает в праметры конструктора Snake начальную точку в классе Program
                p.Move(i, _direction); //Смещает эту точку в заданном напрвлении в зависимости от direction
                points.Add(p); //Кладет эти точки в список points
            }
            
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Drow();
        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                points.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void HandelKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
    }
}
