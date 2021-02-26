using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Point
    {
        public int x;       //кордината
        public int y;       //кордината
        public char sym;    //символ

        public Point(int _x, int _y, char _sym) //принимает из Program зачения кординат и материала
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Drow() //Прорисовка
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public Point(Point p) //Реализация собстввенного экземпляра с именем "П" - Механизм -
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.UP)
            {
                y -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                y += offset;
            }
        }

        public override string ToString()
        {
            return $"{x}, {y}, {sym}";
        }

        internal void Clear()
        {
            sym = ' ';
            Drow();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        
    }
}
