﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class FoodCreator
    {
        public int mapWidth;
        public int mapHeight;
        public char sym;

        Random randValue = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        { 
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood() 
        {
            int x = randValue.Next(2, mapWidth - 2);
            int y = randValue.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
