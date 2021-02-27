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

        internal bool IsHit(Figura figura)
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
