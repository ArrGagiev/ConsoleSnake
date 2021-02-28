using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Walls
    {
        List<Figura> wallList;

        //Тут конструктор принимает габарыты карты и создает и кладёт линии в список типа Figura
        //Благодаря полиморфизму мы можем класть в него объекты класса наследников
        public Walls(int _mapWidth, int _mapHeight) 
        {
            wallList = new List<Figura>();

            HorizLine topHorizLine = new HorizLine(1, 115, 0, '#');         //кординыты
            HorizLine bottomHorizLine = new HorizLine(1, 115, 28, '#');    //и прорисовка
            VertiLine leftVertiLine = new VertiLine(1, 28, 1, '#');       //игрового поля!
            VertiLine rightVertiLine = new VertiLine(1, 28, 115, '#');   //................

            wallList.Add(topHorizLine);
            wallList.Add(bottomHorizLine);
            wallList.Add(leftVertiLine);
            wallList.Add(rightVertiLine);
        }

        internal bool HittingTheWall(Figura figura) //Локально, проверка удара змейки о стену (тут figura и есть змейка)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figura))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.DrawLine();
            }
        }
    }
}
