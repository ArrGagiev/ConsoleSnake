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

            Point point = new Point(3, 5, '*'); //кординаты и материал элементов
            Snake snake = new Snake(point, 4, Direction.RIGHT); /* - кординаты и материал 
                                                                 * - их количество (количество элементов змейки) 
                                                                 * - направление наращивания элементов змейки */
            snake.DrawLine(); //их вывод на экран консоли


            FoodCreator foodCreator = new FoodCreator(115, 28, '$'); //
            Point food = foodCreator.CreateFood();                  // Создание еды для змейки
            food.Draw();                                           //
            
            while (true)
            {
                if (walls.HittingTheWall(snake) || snake.BodyBlow()) //Проверка на столкновение либо с телом либо со стеной
                {
                    break;
                }
                if (snake.Eat(food)) //Проверка на то съела ли змейка еду
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(150); //В данном контексте Thread.Sleep влияет на скорость перемещения змейки

                if (Console.KeyAvailable) //Получение и передача данных с клавиатуры в класс snake
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandelKey(key.Key);
                }
            }
        }
    }
}
