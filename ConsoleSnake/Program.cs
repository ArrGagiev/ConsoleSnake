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
            Walls walls = new Walls(115, 28);
            walls.Draw();

            Point point = new Point(3, 5, '*'); //кординаты и материал - создание самого же себя - конструктор
            Snake snake = new Snake(point, 4, Direction.RIGHT); /* - кординаты и материал 
                                                                 * - их количество (количество элементов себя) 
                                                                 * - направление прироста элементов         */
            snake.DrawLine(); //их вывод на экран консоли


            FoodCreator foodCreator = new FoodCreator(115, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitBody())
                {
                    break;
                }
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
    }
}
