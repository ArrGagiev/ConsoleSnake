using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizLine topHorizLine = new HorizLine(1, 115, 0, '.');     //
            topHorizLine.DrawLine();                                    //
            HorizLine bottomHorizLine = new HorizLine(1, 115, 28, '.'); //
            bottomHorizLine.DrawLine();                                 //      кординыты
            VertiLine leftVertiLine = new VertiLine(1, 28, 1, '.');     //      и прорисовка
            leftVertiLine.DrawLine();                                   //      игрового поля!
            VertiLine rightVertiLine = new VertiLine(1, 28, 115, '.');  //
            rightVertiLine.DrawLine();                                  //

            Point point = new Point(3, 5, '*'); //кординаты и материал - создание самого же себя - конструктор
            Snake snake = new Snake(point, 4, Direction.RIGHT); /* - кординаты и материал 
                                                                 * - их количество (количество элементов себя) 
                                                                 * - направление прироста элементов         */
            snake.DrawLine(); //их вывод на экран консоли


            FoodCreator foodCreator = new FoodCreator(115, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            //---------------------------------------------------------------------------------------------------Test╖
            HorizLine h1 = new HorizLine(7, 15, 9,'0');
            Draaaw(h1);

            Point p1 = new Point(20, 20, '+');
            Figura f_Snake = new Snake(p1, 30, Direction.DOWN);
            Draaaw(f_Snake);

            //---------------------------------------------------------------------------------------------------Test╜
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandelKey(key.Key);
                }
            }
        }

        //---------------------------------------------------------------------------------------------------Test
        static void Draaaw(Figura figura)
        {
            figura.DrawLine();
        }

    }
}
