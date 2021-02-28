using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;

        Random randValue = new Random();

        //В это методе указываем габариты экрана и тот символ который выступит в качестве еды
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        { 
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        //Создаем ту саму еду в рандомном месте нашего экрана
        public Point CreateFood() 
        {
            int x = randValue.Next(2, mapWidth - 2);
            int y = randValue.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
