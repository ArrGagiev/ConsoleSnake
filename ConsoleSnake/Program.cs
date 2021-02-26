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
            topHorizLine.DrowLine();                                    //
            HorizLine bottomHorizLine = new HorizLine(1, 115, 28, '.'); //
            bottomHorizLine.DrowLine();                                 //      кординыты
            VertiLine leftVertiLine = new VertiLine(1, 28, 1, '.');     //      и прорисовка
            leftVertiLine.DrowLine();                                   //      игрового поля!
            VertiLine rightVertiLine = new VertiLine(1, 28, 115, '.');  //
            rightVertiLine.DrowLine();                                  //

            Point point = new Point(3, 5, '*'); //кординаты и материал - создание самого же себя - конструктор
            Snake snake = new Snake(point, 4, Direction.RIGHT); /* - кординаты и материал 
                                                                 * - их количество (количество элементов себя) 
                                                                 * - направление прироста элементов         */
            snake.DrowLine(); //их вывод на экран консоли

            FoodCreator foodCreator = new FoodCreator(115, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Drow();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
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

        
    }
}
